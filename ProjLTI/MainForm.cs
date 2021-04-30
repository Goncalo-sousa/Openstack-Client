
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace ProjLTI
{
    public partial class MainForm : Form
    {
        public String authToken; // VARIAVEL PARA COLOCAR O TOKEN RECEBIDO VIA KEYSTONE
        //public String instanceId = "c3cc8eaa-838f-43ab-a522-fa1475606bd7"; // ID DE UMA INSTANCIA ESPECIFICA DO PROJETO demo
        public Project idProject;
        public Boolean authenticated = false;
        public String ipaddrWithPort = "";
        public String ipaddr = "";
        public ImageFile file;
        public int oldSelected;
        

        public object MessegeBox { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            beforeLoginShow();

            if (this.comboBoxProject.SelectedIndex != oldSelected)
            {
                statistics();
                oldSelected = this.comboBoxProject.SelectedIndex;
            }




        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            if (this.textBoxAddPort != null)
            {
                ipaddr = this.textBoxIPServer.Text; ///////!!!!! descomentar no fim !!!!!!!!!!!!!!!!!!! //////////////
                ipaddrWithPort = this.textBoxIPServer.Text +":" +this.textBoxAddPort.Text;

            }
            else
            {
                ipaddr = this.textBoxIPServer.Text; ///////!!!!! descomentar no fim !!!!!!!!!!!!!!!!!!! //////////////
                ipaddrWithPort = ipaddr;

            }

            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST
            if (this.textBoxPassword == null || this.textBoxUsername == null || ipaddr == null)
            {
                MessageBox.Show("username or password is empty!");

            }

            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}}}}";
            //String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\"demo\",\"domain\":{\"name\":\"Default\"},\"password\":\"devstack\"}}}}}";

            // ... PEDIDO POST AO API DO KEYSTONE
           
            var responseString = myWebClient.UploadString("http://" + ipaddrWithPort + "/identity/v3/auth/tokens", jsonToSend);
            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;

           

            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollection.Get(i);
                }
            }


            myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            

            var data = myWebClient.DownloadString("http://" + ipaddrWithPort + "/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);
            foreach (var item in projects.projects)
            {
                createlistBoxProjects(item.Id, item.Name, item.Self);
            }


            afterLoginShow();
            this.labelUser.Show();
            this.labelUserLogin.Text = this.textBoxUsername.Text;
            this.label_IP.Text = ipaddr;
            this.comboBoxProject.SelectedIndex = 0;
            oldSelected = this.comboBoxProject.SelectedIndex;
            authWithToken();
            statistics();


        }

        public void createlistBoxProjects(string id, string name, string url)
        {
            

            this.comboBoxProject.Items.Add(name);
        }

       



        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            VolumesForm formAux = new VolumesForm(this);
            formAux.ShowDialog();
            statistics();

        }

        public AllVolumes projectDetails()
        {

            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

            myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var data = myWebClient.DownloadString("http://" + ipaddrWithPort + "/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.comboBoxProject.SelectedIndex;

            if (projectIndex == -1)
            {
                MessageBox.Show("No project selected!");
                return null;
            }
            else
            {
                
                authWithToken();
                myWebClient = new WebClient();
                myWebClient.Headers.Add("X-Auth-Token", authToken);

                var dataVolumes = myWebClient.DownloadString("http://" + ipaddrWithPort + "/volume/v3/" + idProject.Id + "/volumes/detail");
                var volumes = JsonConvert.DeserializeObject<AllVolumes>(dataVolumes);
                return volumes;
            }
        }


        public AllVirtualMachines instances()
        {
            if (!authenticated || this.comboBoxProject.SelectedIndex != oldSelected)
            {
               
                refreshStats();
            }

            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            
            var dataVMs = myWebClient.DownloadString("http://" + ipaddrWithPort + "/compute/v2.1/servers/detail");
            var servers = JsonConvert.DeserializeObject<AllVirtualMachines>(dataVMs);
            return servers;
        }

        public AllImages images()
        {
            if (!authenticated || this.comboBoxProject.SelectedIndex != oldSelected)
            {
                authWithToken();
            }

            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            
            var dataImages = myWebClient.DownloadString("http://" + ipaddrWithPort + "/image/v2/images");
            var images = JsonConvert.DeserializeObject<AllImages>(dataImages);
         
            return images;
        }



        public void creationVolume(string dataCreation)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            
            var responseVolumes = myWebClient.UploadString("http://" + ipaddrWithPort + "/volume/v3/" + idProject.Id + "/volumes", dataCreation);

          
        }

        private void afterLoginShow()
        {
            /*------------- login ----------------*/
            this.labelUsername.Hide();
            this.labelPass.Hide();
            this.labelServer.Hide();
            this.btnLogin.Hide();
            this.textBoxPassword.Hide();
            this.textBoxUsername.Hide();
            this.textBoxIPServer.Hide();
            this.labelPortLogin.Hide();
            this.textBoxAddPort.Hide();
            /* ----------- Buttons ---------------- */
            this.btnOpenProject.Show();
            this.btnContainers.Show();
            this.btnImages.Show();
            this.btnInstances.Show();
            /*------------ Top window -------------*/

            this.labelServidor.Show();
            this.labelUser.Show();
            this.labelUserLogin.Show();
            this.label_IP.Show();

            this.labelProjectTop.Show();
            this.comboBoxProject.Show();
            this.btnRefreshStats.Show();
            /*------------ status -----------------*/
            this.labelComputeBold.Show();
            this.labelInstancesTitle.Show();
            this.labelRAMTitle.Show();
            this.labelSeparador.Show();
            this.labelstatsInstances.Show();
            this.labelstatsRAM.Show();
            this.labelstatsVolumes.Show();
            this.labelstatsVolumeSnaps.Show();
            this.labelstatsVolumeStorage.Show();
            this.labelVCPUsTitle.Show();
            this.labelVolumesBold.Show();
            this.labelVolumesSnapTitle.Show();
            this.labelVolumeStorageTitle.Show();
            this.labelstatsVCPUs.Show();
            this.labelVolumesTitle.Show();
        }

        private void beforeLoginShow()
        {
            /* buttons */
            this.btnOpenProject.Hide();
            this.btnContainers.Hide();
            this.btnImages.Hide();
            this.btnInstances.Hide();
            /* Top window */
            this.labelUser.Hide();
            this.labelUserLogin.Hide();
            this.labelServidor.Hide();
            this.label_IP.Hide();

            this.labelProjectTop.Hide();
            this.comboBoxProject.Hide();
            this.btnRefreshStats.Hide();

            /* status */
            this.labelComputeBold.Hide();
            this.labelInstancesTitle.Hide();
            this.labelRAMTitle.Hide();
            this.labelSeparador.Hide();
            this.labelstatsInstances.Hide();
            this.labelstatsRAM.Hide();
            this.labelstatsVolumes.Hide();
            this.labelstatsVolumeSnaps.Hide();
            this.labelstatsVolumeStorage.Hide();
            this.labelVCPUsTitle.Hide();
            this.labelVolumesBold.Hide();
            this.labelVolumesSnapTitle.Hide();
            this.labelVolumeStorageTitle.Hide();
            this.labelstatsVCPUs.Hide();
            this.labelVolumesTitle.Hide();

        }

       
        public void uploadImage(string name, string disk_format, string container_format)
        {
            if (!authenticated || this.comboBoxProject.SelectedIndex != oldSelected)
            {
                
                refreshStats();
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();  //abrir o ficheiro
            openFileDialog.Filter = "Cloud Image (*.ami, *.ari, *.aki, *.vhd, *.vhdx, *.vmdk, *.raw, *.qcow2, *.vdi, *.ploop, *.iso) | *.ami; *.ari; *.aki; *.vhd; *.vhdx; *.vmdk; *.raw; *.qcow2; *.vdi; *.ploop; *.iso"; //filtrar por tipo de ficheiro
            String fileContent;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathFile = openFileDialog.FileName;
                //MessageBox.Show(pathFile);
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();

                }

                if (authenticated)
                {
                    var myWebClient = new WebClient();
                    myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    myWebClient.Headers.Add("X-Auth-Token", authToken);
                    String jsonToSend = "{\"container_format\":" + "\"" + container_format + "\"" + ",\"disk_format\":" + "\"" + disk_format + "\"" + ",\"name\":" + "\"" + name + "\"" + "}";
                    var dataVMs = myWebClient.UploadString("http://" + ipaddrWithPort + "/image/v2/images", jsonToSend);
                   
                    var file = JsonConvert.DeserializeObject<ImageFile>(dataVMs);


                    var myWebClientFile = new WebClient();
                    myWebClientFile.Headers[HttpRequestHeader.ContentType] = "application/octet-stream";
                    myWebClientFile.Headers.Add("X-Auth-Token", authToken);
                   
                    var responseVolumes = myWebClientFile.UploadString("http://" + ipaddrWithPort + "/image" + file.File, WebRequestMethods.Http.Put, fileContent);

                }
            }
        }

        private void authWithToken()
        {
            
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var data = myWebClient.DownloadString("http://" + ipaddrWithPort + "/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.comboBoxProject.SelectedIndex;

            idProject = projects.projects[projectIndex];

            
            String jsonWithScope = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}},\"scope\": {\"project\": {\"id\":" + "\"" + idProject.Id + "\"}}}}";


            var responseStringScoped = myWebClient.UploadString("http://" + ipaddrWithPort + "/identity/v3/auth/tokens", jsonWithScope);
            WebHeaderCollection myWebHeaderCollectionScoped = myWebClient.ResponseHeaders;


            for (int i = 0; i < myWebHeaderCollectionScoped.Count; i++)
            {
                if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollectionScoped.Get(i);
                }
            }

            authenticated = true;
            oldSelected = this.comboBoxProject.SelectedIndex;

          

        }

        public void deleteImage(string idImage)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            myWebClient.UploadString("http://" + ipaddrWithPort + "/image/v2/images/" + idImage, "DELETE", string.Empty);

        }
        public void deleteInstance(string idInstance)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            myWebClient.UploadString("http://" + ipaddrWithPort + "/compute/v2.1/servers/" + idInstance, "DELETE", string.Empty);

        }

        private void btnInstances_Click(object sender, EventArgs e)
        {
            InstancesForm formAux = new InstancesForm(this);
            formAux.ShowDialog();
            statistics();

        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            ImagesForm formAux = new ImagesForm(this);
            formAux.ShowDialog();
            statistics();

        }

        public AllFlavors getFlavors()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var dataFlavors = myWebClient.DownloadString("http://" + ipaddrWithPort + "/compute/v2.1/flavors");
            var flavors = JsonConvert.DeserializeObject<AllFlavors>(dataFlavors);
            return flavors;

        }

        public AllNetworks getNetworks()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var dataNetworks = myWebClient.DownloadString("http://" + ipaddr + ":9696/v2.0/networks");
            var networks = JsonConvert.DeserializeObject<AllNetworks>(dataNetworks);
            return networks;

        }

        public void createInstances(string name, string idFlavor, string idImage, string idNetwork)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            var jsonToCreation = "{\"server\":{\"name\":" + "\"" + name + "\"" + ",\"flavorRef\":\"http://127.0.0.1:8080/compute/v2.1/flavors/" + idFlavor + "\"" + ",\"imageRef\":" + "\"" + idImage + "\"" + ",\"networks\":[{\"uuid\":" + "\"" + idNetwork + "\"" + "}]}}";
            myWebClient.UploadString("http://" + ipaddrWithPort + "/compute/v2.1/servers", jsonToCreation);
        }

        public void editInstance(string name, string idInstance)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            var jsonToEdit = "{\"server\":{\"name\":" + "\"" + name + "\"" + "}}";
            myWebClient.UploadString("http://" + ipaddrWithPort + "/compute/v2.1/servers/" + idInstance, WebRequestMethods.Http.Put, jsonToEdit);
        }

        private void statistics()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            if (this.comboBoxProject.SelectedIndex != -1)
            {
                var dataStatsCompute = myWebClient.DownloadString("http://" + ipaddrWithPort + "/compute/v2.1/os-quota-sets/" + idProject.Id + "/detail");
                var statsCompute = JsonConvert.DeserializeObject<dynamic>(dataStatsCompute);
                string coresInUse = statsCompute["quota_set"]["cores"]["in_use"];
                string coresLimit = statsCompute["quota_set"]["cores"]["limit"];
                string instancesInUse = statsCompute["quota_set"]["instances"]["in_use"];
                string instancesLimit = statsCompute["quota_set"]["instances"]["limit"];
                string ramInUse = statsCompute["quota_set"]["ram"]["in_use"];
                string ramLimit = statsCompute["quota_set"]["ram"]["limit"];
                ramInUse = BytesToString(long.Parse(ramInUse));
                ramLimit = BytesToStringRamLimit(long.Parse(ramLimit));
                this.labelstatsInstances.Text = "Utilizado " + instancesInUse + " de " + instancesLimit;
                this.labelstatsVCPUs.Text = "Utilizado " + coresInUse + " de " + coresLimit;
                this.labelstatsRAM.Text = "Utilizado " + ramInUse + " de " + ramLimit;

                var dataStatsVolumes = myWebClient.DownloadString("http://" + ipaddrWithPort + "/volume/v3/" + idProject.Id + "/limits");
                var statsVolumes = JsonConvert.DeserializeObject<dynamic>(dataStatsVolumes);
                string volumesLimit = statsVolumes["limits"]["absolute"]["maxTotalVolumes"];
                string volumesInUse = statsVolumes["limits"]["absolute"]["totalVolumesUsed"];
                string volumesLimitSnaps = statsVolumes["limits"]["absolute"]["maxTotalSnapshots"];
                string volumesInUseSnaps = statsVolumes["limits"]["absolute"]["totalSnapshotsUsed"];
                string volumesLimitStorage = statsVolumes["limits"]["absolute"]["maxTotalVolumeGigabytes"];
                string volumesInUseStorage = statsVolumes["limits"]["absolute"]["totalGigabytesUsed"];
                volumesInUseStorage = volumesInUseStorage + " GB";
                volumesLimitStorage = volumesLimitStorage + " GB";
                this.labelstatsVolumes.Text = "Utilizado " + volumesInUse + " de " + volumesLimit;
                this.labelstatsVolumeSnaps.Text = "Utilizado " + volumesInUseSnaps + " de " + volumesLimitSnaps;
                this.labelstatsVolumeStorage.Text = "Utilizado " + volumesInUseStorage + " de " + volumesLimitStorage;


            }


        }

        private void refreshStats()
        {
            authWithToken();
            statistics();
        }

        private void btnRefreshStats_Click(object sender, EventArgs e)
        {
            refreshStats();
        }

        private void btnContainers_Click(object sender, EventArgs e)
        {
            ContainersForm formAux = new ContainersForm(this);
            formAux.ShowDialog();
        }

        public AllContainers getContainers()
        {
            if (!authenticated || this.comboBoxProject.SelectedIndex != oldSelected)
            {
                
                refreshStats();
            }
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var dataContainers = myWebClient.DownloadString("http://" + ipaddrWithPort + "/container/v1/containers");
            var containers = JsonConvert.DeserializeObject<AllContainers>(dataContainers);
            return containers;
        }

        public async void createContainer(string nameSelected, string imageSelected)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            string jsonToCreate = "{\"image\":" + "\"" + imageSelected + "\"" + ",\"name\":" + "\"" + nameSelected + "\"" + "}";
            var response = myWebClient.UploadString("http://" + ipaddrWithPort + "/container/v1/containers", jsonToCreate);
            await Task.Delay(30);
        }

        public async void deleteContainer(string idContainer, string statusContainer)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            string containerID = idContainer;

            if (statusContainer == "Running")
            {
                var responseStop = myWebClient.UploadString("http://" + ipaddrWithPort + "/container/v1/containers/" + containerID + "/stop", WebRequestMethods.Http.Post, string.Empty);
                await Task.Delay(30000);
            }

            var responseDelete = myWebClient.UploadString("http://" + ipaddrWithPort + "/container/v1/containers/" + containerID, "DELETE", string.Empty);

        }

        public async void startContainer(string idContainer, string statusContainer)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            if (statusContainer == "Running")
            {
                MessageBox.Show("Already running!");
            }
            else
            {
                var responseStop = myWebClient.UploadString("http://" + ipaddrWithPort + "/container/v1/containers/" + idContainer + "/start", WebRequestMethods.Http.Post, string.Empty);
                await Task.Delay(8000);
            }
        }

        public async void stopContainer(string idContainer, string statusContainer)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            if (statusContainer == "Stopped")
            {
                MessageBox.Show("Already stopped!");
            }
            else
            {
                var responseStop = myWebClient.UploadString("http://" + ipaddrWithPort + "/container/v1/containers/" + idContainer + "/stop", WebRequestMethods.Http.Post, string.Empty);
                await Task.Delay(8000);
            }
        }

        private String BytesToString(long byteCount)
        {
            string[] suf = { " Bytes", " KB", " MB", " GB", " TB", " PB", " EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private String BytesToStringRamLimit(long byteCount)
        {
            string[] suf = { " Bytes", " KB", " MB", " GB", " TB", " PB", " EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[3];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}


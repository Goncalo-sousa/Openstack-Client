
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
    public partial class Main : Form
    {
        public String authToken; // VARIAVEL PARA COLOCAR O TOKEN RECEBIDO VIA KEYSTONE
        public String instanceId = "c3cc8eaa-838f-43ab-a522-fa1475606bd7"; // ID DE UMA INSTANCIA ESPECIFICA DO PROJETO demo
        public Project idProject;
        public Boolean authenticated = false;
        public String ipaddr = "178.128.137.202";
        public Image file;

        public object MessegeBox { get; private set; }

        public Main()
        {
            InitializeComponent();
            this.btnOpenProject.Hide();
            this.labelUser.Hide();
            this.labelServidor.Hide();
            

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            // EXEMPLO DE UM PEDIDO POST DIRIGIDO AO API DO SERVIÇO KEYSTONE (IDENTITY)
            // PROJECT-SCOPED TOKEN: user demo (id: d1b3ce3c523748eb8ba056775b7dca9d), password devstack, project demo (id: 9fadd03b32124fd2b7130f6ad094a299)


            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";


            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST

            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\""+ this.textBoxUsername +"\",\"domain\":{\"name\":\"Default\"},\"password\":\""+this.textBoxPassword+"\"}}}}}";

            // ... PEDIDO POST AO API DO KEYSTONE

            var responseString = myWebClient.UploadString("http://127.0.0.1:8080/identity/v3/auth/tokens", jsonToSend);
            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;

            // ... RETIRAR DOS HEADERS RECEBIDOS NA RESPOSTA O TOKEN

            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollection.Get(i);
                }
            }

            // ... MOSTRAR O TOKEN NO ECRAN

            MessageBox.Show(authToken, "Token de autenticação do OpenStack");


            // EXEMPLO DE UM PEDIDO GET DIRIGIDO AO API DO SERVIÇO NOVA (COMPUTE) UTILIZANDO UM TOKEN DE AUTENTICAÇÃO

            myWebClient = new WebClient();
            myWebClient.Headers.Add("x-auth-token", authToken);

            String url = "http://127.0.0.1:8080/compute/v2.1/servers/" + instanceId;

            // String url = "http://127.0.0.1:8080/compute/v2.1/servers"; // A UTILIZAR SE SE PRETENDER OBTER TODAS AS INSTANCIAS DO PROJETO

            // ... PEDIDO GET AO API DO NOVA

            responseString = myWebClient.DownloadString(url);

            // ... MOSTRAR O JSON RECEBIDO NO ECRAN

            MessageBox.Show(responseString, "Resposta enviada do Openstack em Json");




            // CONVERTER DE JSON PARA XML (INSTALAR A json.net VIA nugget)

            XmlDocument xdoc = JsonConvert.DeserializeXmlNode(responseString);


            // ... MOSTRAR O XML OBTIDO NO ECRAN

            MessageBox.Show(xdoc.OuterXml, "XML criado a partir do Json recebido do OpenStack");




            // CONVERTER DE XML PARA JSON 

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xdoc.OuterXml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);


            // ... MOSTRAR O JSON OBTIDO NO ECRAN

            MessageBox.Show(jsonText, "Json criado a partir do XML convertido");



            //projetos
            var projects = myWebClient.DownloadString("http://127.0.0.1:8080/identity/v3/auth/projects");
            MessageBox.Show(projects, "Projetos");
            //JsonObject jsonObject = new JsonObject(projects);

        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

            //ipaddr = this.textBoxIPServer.Text; ///////!!!!! descomentar no fim !!!!!!!!!!!!!!!!!!! //////////////

            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST
            if ( this.textBoxPassword == null || this.textBoxUsername == null || ipaddr == null)
            {
                MessageBox.Show("username or password is empty!");
            }
           
            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":"+"\""+ this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":"+"\"" + this.textBoxPassword.Text + "\"}}}}}";
            //String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\"demo\",\"domain\":{\"name\":\"Default\"},\"password\":\"devstack\"}}}}}";

            // ... PEDIDO POST AO API DO KEYSTONE

            var responseString = myWebClient.UploadString("http://"+ipaddr+"/identity/v3/auth/tokens", jsonToSend);
            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;

            // ... RETIRAR DOS HEADERS RECEBIDOS NA RESPOSTA O TOKEN

            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollection.Get(i);
                }
            }

            // ... MOSTRAR O TOKEN NO ECRAN

           // MessageBox.Show(authToken, "Token de autenticação do OpenStack");


            // EXEMPLO DE UM PEDIDO GET DIRIGIDO AO API DO SERVIÇO NOVA (COMPUTE) UTILIZANDO UM TOKEN DE AUTENTICAÇÃO

            myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);

          //  String url = "http://127.0.0.1:8080/compute/v2.1/servers/" + instanceId;

            //String url = "http://127.0.0.1:8080/compute/v2.1/servers"; // A UTILIZAR SE SE PRETENDER OBTER TODAS AS INSTANCIAS DO PROJETO

            // ... PEDIDO GET AO API DO NOVA

            // responseString = myWebClient.DownloadString(url);

            // ... MOSTRAR O JSON RECEBIDO NO ECRAN

            // MessageBox.Show(responseString, "Resposta enviada do Openstack em Json");
           

            var data = myWebClient.DownloadString("http://"+ipaddr+"/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);
            foreach (var item in projects.projects)
            {
                createlistBoxProjects(item.Id, item.Name, item.Self);
            }

            
            remendo();
            this.labelUser.Show();
            this.labelUserLogin.Text = this.textBoxUsername.Text;
            this.label_IP.Text = ipaddr;
            this.comboBoxProject.SelectedIndex = 0;
            authWithToken();


        }

        public void createlistBoxProjects(string id, string name, string url)
        {
            string aux = "Id:" + id + " || Name:" + name + " || Url:" + url;

            this.comboBoxProject.Items.Add(name);
        }

        /*public void createlistBoxVMS(string id, string name)
        {

            string aux = "Id:" + id + " || Name:" + name;

            this.listBoxVMs.Items.Add(aux);
        }*/

        

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            Volumes formAux = new Volumes(this);
            formAux.ShowDialog();

         
        }

        public AllVolumes projectDetails()
        {
            
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

            myWebClient = new WebClient();
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var data = myWebClient.DownloadString("http://"+ipaddr+"/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.comboBoxProject.SelectedIndex;
            
            if ( projectIndex == -1)
            {
                MessageBox.Show("No project selected!");
                return null;
            }
            else
            {
                /*idProject = projects.projects[projectIndex];

                MessageBox.Show(idProject.Id);
                myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

                if (this.textBoxPassword == null && this.textBoxUsername == null)
                {
                    MessageBox.Show("username or password is empty!");
                }


                String jsonWithScope = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}},\"scope\": {\"project\": {\"id\":" + "\"" + idProject.Id + "\"}}}}";


                var responseStringScoped = myWebClient.UploadString("http://178.128.137.202/identity/v3/auth/tokens", jsonWithScope);
                WebHeaderCollection myWebHeaderCollectionScoped = myWebClient.ResponseHeaders;


                for (int i = 0; i < myWebHeaderCollectionScoped.Count; i++)
                {
                    if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                    {
                        authToken = myWebHeaderCollectionScoped.Get(i);
                    }
                }
*/
                authWithToken();
                myWebClient = new WebClient();
                myWebClient.Headers.Add("X-Auth-Token", authToken);

                MessageBox.Show(authToken);
                var dataVolumes = myWebClient.DownloadString("http://"+ipaddr+"/volume/v3/" + idProject.Id + "/volumes/detail");
                var volumes = JsonConvert.DeserializeObject<AllVolumes>(dataVolumes);
                return volumes;
            }
        }
        

        public AllVirtualMachines instances()
        {
            authWithToken();
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            Console.WriteLine(authToken);
            var dataVMs = myWebClient.DownloadString("http://" + ipaddr + "/compute/v2.1/servers");
            var servers = JsonConvert.DeserializeObject<AllVirtualMachines>(dataVMs);
            return servers;
        }
        
        public AllImages images()
        {
            authWithToken();
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            Console.WriteLine(authToken);
            var dataImages = myWebClient.DownloadString("http://" + ipaddr + "/image/v2/images");
            Console.WriteLine(dataImages);
            var images = JsonConvert.DeserializeObject<AllImages>(dataImages);
            Console.WriteLine(images);
            return images;
        }



        public void creationVolume (string dataCreation)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            MessageBox.Show(idProject.Id + " and " + dataCreation +" adn " + authToken);
            var responseVolumes = myWebClient.UploadString("http://"+ipaddr+"/volume/v3/" + idProject.Id + "/volumes", dataCreation);

            MessageBox.Show(responseVolumes);
        }

        /*private void btnShowVMs_Click(object sender, EventArgs e)
        {

            this.listBoxVMs.Items.Clear();
            authWithToken();
            var myWebClient = new WebClient();
            *//*myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var data = myWebClient.DownloadString("http://178.128.137.202/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.comboBoxProject.SelectedIndex;

            idProject = projects.projects[projectIndex];

           // MessageBox.Show(idProject.Id);
            String jsonWithScope = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}},\"scope\": {\"project\": {\"id\":" + "\"" + idProject.Id + "\"}}}}";


            var responseStringScoped = myWebClient.UploadString("http://178.128.137.202/identity/v3/auth/tokens", jsonWithScope);
            WebHeaderCollection myWebHeaderCollectionScoped = myWebClient.ResponseHeaders;


            for (int i = 0; i < myWebHeaderCollectionScoped.Count; i++)
            {
                if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollectionScoped.Get(i);
                }
            }*//*

           // myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);


            var dataVMs = myWebClient.DownloadString("http://"+ipaddr+"/compute/v2.1/servers");
            var servers = JsonConvert.DeserializeObject<AllVirtualMachines>(dataVMs);
            //MessageBox.Show(dataVMs + " adn "+ authToken);
            foreach (var itemVM in servers.servers)
            {
                createlistBoxVMS(itemVM.Id, itemVM.Name);
            }
           
        }*/
        public void remendo()
        {
            this.labelUsername.Hide();
            this.labelPass.Hide();
            this.labelServer.Hide();
            this.btnLogin.Hide();
            this.textBoxPassword.Hide();
            this.textBoxUsername.Hide();
            this.textBoxIPServer.Hide();
            this.btnOpenProject.Show();
            this.labelServidor.Show();
            this.labelUser.Show();

        }

        /*private void btnUploadImage_Click(object sender, EventArgs e)
        {
            authWithToken();
            OpenFileDialog openFileDialog = new OpenFileDialog();  //abrir o ficheiro
            openFileDialog.Filter = "Cloud Image (*.ami, *.ari, *.aki, *.vhd, *.vhdx, *.vmdk, *.raw, *.qcow2, *.vdi, *.ploop, *.iso) | *.ami; *.ari; *.aki; *.vhd; *.vhdx; *.vmdk; *.raw; *.qcow2; *.vdi; *.ploop; *.iso"; //filtrar por tipo de ficheiro
            String fileContent;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathFile = openFileDialog.FileName;
                MessageBox.Show(pathFile);
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
                    String jsonToSend = "{\"container_format\":\"bare\",\"disk_format\":\"raw\",\"name\":\"PostmanImage2\"}";
                   var dataVMs = myWebClient.UploadString("http://" + ipaddr + "/image/v2/images", jsonToSend);
                    MessageBox.Show(dataVMs);
                    var file = JsonConvert.DeserializeObject<Image>(dataVMs);


                    var myWebClientFile = new WebClient();
                    myWebClientFile.Headers[HttpRequestHeader.ContentType] = "application/octet-stream";
                    myWebClientFile.Headers.Add("X-Auth-Token", authToken);
                    MessageBox.Show(file.File);
                    var responseVolumes = myWebClientFile.UploadString("http://" + ipaddr + "/image" + file.File,WebRequestMethods.Http.Put ,fileContent);

                    

                }
              
            }

        }*/
        public void uploadImage(string name, string disk_format, string container_format)
        {
            authWithToken();
            OpenFileDialog openFileDialog = new OpenFileDialog();  //abrir o ficheiro
            openFileDialog.Filter = "Cloud Image (*.ami, *.ari, *.aki, *.vhd, *.vhdx, *.vmdk, *.raw, *.qcow2, *.vdi, *.ploop, *.iso) | *.ami; *.ari; *.aki; *.vhd; *.vhdx; *.vmdk; *.raw; *.qcow2; *.vdi; *.ploop; *.iso"; //filtrar por tipo de ficheiro
            String fileContent;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pathFile = openFileDialog.FileName;
                MessageBox.Show(pathFile);
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
                    String jsonToSend = "{\"container_format\":" +"\""+container_format+"\""+",\"disk_format\":"+"\""+disk_format+"\""+",\"name\":"+"\""+name+"\""+"}";
                    var dataVMs = myWebClient.UploadString("http://" + ipaddr + "/image/v2/images", jsonToSend);
                    MessageBox.Show(dataVMs);
                    var file = JsonConvert.DeserializeObject<Image>(dataVMs);


                    var myWebClientFile = new WebClient();
                    myWebClientFile.Headers[HttpRequestHeader.ContentType] = "application/octet-stream";
                    myWebClientFile.Headers.Add("X-Auth-Token", authToken);
                    MessageBox.Show(file.File);
                    var responseVolumes = myWebClientFile.UploadString("http://" + ipaddr + "/image" + file.File, WebRequestMethods.Http.Put, fileContent);

                }
            }
        }

        public void authWithToken()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var data = myWebClient.DownloadString("http://"+ipaddr+"/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.comboBoxProject.SelectedIndex;
            
                idProject = projects.projects[projectIndex];

                // MessageBox.Show(idProject.Id);
                String jsonWithScope = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}},\"scope\": {\"project\": {\"id\":" + "\"" + idProject.Id + "\"}}}}";


                var responseStringScoped = myWebClient.UploadString("http://" + ipaddr + "/identity/v3/auth/tokens", jsonWithScope);
                WebHeaderCollection myWebHeaderCollectionScoped = myWebClient.ResponseHeaders;


                for (int i = 0; i < myWebHeaderCollectionScoped.Count; i++)
                {
                    if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                    {
                        authToken = myWebHeaderCollectionScoped.Get(i);
                    }
                }

                authenticated = true;
         
            
        }

        public void deleteImage(string idImage)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            myWebClient.UploadString("http://" + ipaddr + "/image/v2/images/" + idImage,"DELETE",string.Empty);

        }
        public void deleteInstance(string idInstance)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            myWebClient.UploadString("http://" + ipaddr + "/compute/v2.1/servers/" + idInstance,"DELETE",string.Empty);

        }

        private void btnInstances_Click(object sender, EventArgs e)
        {
            Instances formAux = new Instances(this);
            formAux.ShowDialog();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            Images formAux = new Images(this);
            formAux.ShowDialog();
        }

        public AllFlavors getFlavors()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var dataFlavors = myWebClient.DownloadString("http://" + ipaddr + "/compute/v2.1/flavors");
            var flavors = JsonConvert.DeserializeObject<AllFlavors>(dataFlavors);

            return flavors;
            
        }

        public AllNetworks getNetworks()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            var dataNetworks = myWebClient.DownloadString("http://" + ipaddr + ":9696/v2.0/networks");
            // var dataNetworks = myWebClient.DownloadString("http://157.245.68.113:9696/v2.0/networks");
            var networks = JsonConvert.DeserializeObject<AllNetworks>(dataNetworks);
            return networks;

        }

        public void createInstances(string name, string idFlavor, string idImage, string idNetwork)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            var jsonToCreation = "{\"server\":{\"name\":" + "\"" + name + "\"" + ",\"flavorRef\":\"http://127.0.0.1:8080/compute/v2.1/flavors/" + idFlavor + "\"" + ",\"imageRef\":" + "\"" + idImage + "\"" + ",\"networks\":[{\"uuid\":" + "\"" + idNetwork + "\"" + "}]}}";
            myWebClient.UploadString("http://" + ipaddr + "/compute/v2.1/servers", jsonToCreation); 
        }

        public void editInstance(string name, string idInstance)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);
            var jsonToEdit = "{\"server\":{\"name\":"+"\""+name+"\""+"}}";
            myWebClient.UploadString("http://" + ipaddr + "/compute/v2.1/servers/"+idInstance, WebRequestMethods.Http.Put, jsonToEdit);
        }

        public void statistics()
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("X-Auth-Token", authToken);

            //var statsCompute = myWebClient.DownloadString("http://" + ipaddr + "/compute/v2.1/os-quota-sets/"+idProject+"/detail");
            //var statsvolumes = myWebClient.DownloadString("http://" + ipaddr + "/compute/v2.1/os-quota-sets/"+idProject+"/detail");

        }
    }
}


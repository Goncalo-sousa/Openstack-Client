
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public String authToken = ""; // VARIAVEL PARA COLOCAR O TOKEN RECEBIDO VIA KEYSTONE
        public String instanceId = "c3cc8eaa-838f-43ab-a522-fa1475606bd7"; // ID DE UMA INSTANCIA ESPECIFICA DO PROJETO demo

        public Main()
        {
            InitializeComponent();
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


            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST
            if ( this.textBoxPassword == null && this.textBoxUsername == null)
            {
                MessageBox.Show("username or password is empty!");
            }
           
            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":"+"\""+ this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":"+"\"" + this.textBoxPassword.Text + "\"}}}}}";
            //String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\"demo\",\"domain\":{\"name\":\"Default\"},\"password\":\"devstack\"}}}}}";

            // ... PEDIDO POST AO API DO KEYSTONE

            var responseString = myWebClient.UploadString("http://178.128.137.202/identity/v3/auth/tokens", jsonToSend);
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
            myWebClient.Headers.Add("x-auth-token", authToken);

          //  String url = "http://127.0.0.1:8080/compute/v2.1/servers/" + instanceId;

            // String url = "http://127.0.0.1:8080/compute/v2.1/servers"; // A UTILIZAR SE SE PRETENDER OBTER TODAS AS INSTANCIAS DO PROJETO

            // ... PEDIDO GET AO API DO NOVA

           // responseString = myWebClient.DownloadString(url);

            // ... MOSTRAR O JSON RECEBIDO NO ECRAN

           // MessageBox.Show(responseString, "Resposta enviada do Openstack em Json");

            var data = myWebClient.DownloadString("http://178.128.137.202/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);
            foreach (var item in projects.projects)
            {
                createlistBoxProjects(item.Id, item.Name, item.Self);
            }
           
        }

        public void createlistBoxProjects(string id, string name, string url)
        {
            //funcao para formatar a string de modo a entrar para a listBox no formato correto, separa os inputs dos outputs atraves
            // da seq "-->" e os tipos dos caminhos atraves da seq <+>
            string aux = "Id:" + id + " || Name:" + name + " || Url:" + url;

            this.listBoxProjects.Items.Add(aux);
        }

        

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            openProject formAux = new openProject(this, listBoxProjects.SelectedIndex);
            formAux.ShowDialog();

         
        }

        public void projectDetails()
        {
            
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

            if (this.textBoxPassword == null && this.textBoxUsername == null)
            {
                MessageBox.Show("username or password is empty!");
            }


            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}}}}";

            var responseString = myWebClient.UploadString("http://178.128.137.202/identity/v3/auth/tokens", jsonToSend);
            WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;


            for (int i = 0; i < myWebHeaderCollection.Count; i++)
            {
                if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                {
                    authToken = myWebHeaderCollection.Get(i);
                }
            }

            myWebClient = new WebClient();
            myWebClient.Headers.Add("x-auth-token", authToken);

            var data = myWebClient.DownloadString("http://178.128.137.202/identity/v3/auth/projects");
            var projects = JsonConvert.DeserializeObject<AllProject>(data);

            var projectIndex = this.listBoxProjects.SelectedIndex;

            var idProject = projects.projects[projectIndex];


            /* myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

             if (this.textBoxPassword == null && this.textBoxUsername == null)
             {
                 MessageBox.Show("username or password is empty!");
             }


             String jsonWithScope = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":" + "\"" + this.textBoxUsername.Text + "\",\"domain\":{\"name\":\"Default\"},\"password\":" + "\"" + this.textBoxPassword.Text + "\"}}},\"scope\": {\"project\": {\"id\":" + "\"" + idProject + "\"}}}}";


             var responseStringScoped = myWebClient.UploadString("http://178.128.137.202/identity/v3/auth/tokens", jsonWithScope);
             WebHeaderCollection myWebHeaderCollectionScoped = myWebClient.ResponseHeaders;


             for (int i = 0; i < myWebHeaderCollectionScoped.Count; i++)
             {
                 if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                 {
                     authToken = myWebHeaderCollectionScoped.Get(i);
                 }
                *//* if (myWebHeaderCollectionScoped.GetKey(i) == "X-Subject-Token")
                 {
                     authToken = myWebHeaderCollectionScoped.Get(i);
                 }*//*
             }

             myWebClient = new WebClient();
             myWebClient.Headers.Add("x-auth-token", authToken);
 */
            //var url = "http://178.128.137.202/volume/v3/" + idProject + "/volumes/detail";
            var dataVolumes = myWebClient.DownloadString("http://178.128.137.202/volume/v3/"+idProject+"/volumes/detail");
            //var project = JsonConvert.DeserializeObject<AllProject>(data);
            MessageBox.Show(dataVolumes);
        }
        
    }
}



using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace ProjLTI
{
    public partial class Form1 : Form
    {
        public String authToken = ""; // VARIAVEL PARA COLOCAR O TOKEN RECEBIDO VIA KEYSTONE
        public String instanceId = "c3cc8eaa-838f-43ab-a522-fa1475606bd7"; // ID DE UMA INSTANCIA ESPECIFICA DO PROJETO demo

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            JsonObject 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";


            // ... UTILIZANDO JSON: CRIAR UMA STRING COM O BODY A SER ENVIADO NO POST

            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\"" + this.textBoxUsername + "\",\"domain\":{\"name\":\"Default\"},\"password\":\"" + this.textBoxPassword + "\"}}}}}";

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
        }
    }
}


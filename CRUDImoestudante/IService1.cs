/**
* Names : Antonio Gonçalves & Nelson Peixoto
* Email: A10851@alunos.ipca.pt & A11271@alunos.ipca.pt
* Date : 20-12-2016
* RESTFULL Web Service 2º Trabalho Prático
* Versao : 1.0
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CRUDImoestudante.App_Data;

namespace CRUDImoestudante
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region UTILIZADOR


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUsersData")]
        List<MultiUtilizadorRespostaPedido> GetUsersData();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SearchUserId/{id}")]
        UtilizadorRespostaPedido SearchUserId(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/AddUser")]
        bool AddUser(UtilizadorRespostaPedido utilizador);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserTypes")]
        List<TipoUserRespostaPedido> GetUserTypes();

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetUserType/{userLogin}")]
         UtilizadorRespostaPedido GetUserType(string userLogin);
        /**
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/ActivateUser")]
        bool ActivateUser(int userId);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/DeativateUser")]
        bool DeativateUser(int userId);**/

        #endregion  end

        #region PAISES

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/UpDatePais")]
        bool UpDatePais(List<PaisRespostaPedido> paises);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/{token}/GetPaises")]
        List<PaisRespostaPedido> GetPaises(string token);

        #endregion  end

        #region CONTRACTO

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetContractData", ResponseFormat = WebMessageFormat.Json)]
        List<aluguer> GetContractData();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/SearchContractId/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        aluguer SearchContractId(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Addcontract", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool Addcontract(aluguer aluguerData);

        #endregion  end

        #region HABITACAO

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetHouseData", ResponseFormat = WebMessageFormat.Json)]
        List<AlojamentoRespostaPedido> GetHouseData();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/SearchHouseId/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        alojamento SearchHouseId(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddHouse", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AddHouse(alojamento aluguerData);

        #endregion  end

        #region COMODIDADES

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetComodData", ResponseFormat = WebMessageFormat.Json)]
        List<comodidadeRespostaPedido> GetComodData();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetComodDataAlojID/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<comodidadeRespostaPedido> GetComodDataAlojID(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/RemoveComod", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool RemoveComod(comodidadeRespostaPedido comodidadeData);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddComodList", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AddComodList(List<comodidadeRespostaPedido> aluguerData);

        [WebInvoke(Method = "POST", UriTemplate = "/AddComod", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AddComod(comodidadeRespostaPedido comod);

        #endregion  end

        #region FACEBOOK


        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/FacePublicHabitacao")]
        bool FacePublicHabitacao(AlojamentoRespostaPedido alojamento);

        #endregion

        #region TWITTER

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/TwittHabitacao")]
        bool TwittHabitacao(AlojamentoRespostaPedido alojamento);

        #endregion

    }
}

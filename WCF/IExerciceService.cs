﻿using Ipme.Hometraining.DTO;
using Ipme.Hometraining.Persistance;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Ipme.Hometraining.WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IExerciceService
    {

        IExerciceManager ExerciceManager { get; }

        [OperationContract]
        IEnumerable<ExerciceDto> GetUsers();

        

        [OperationContract]
        string GetData(int value);

       /* [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
       */
        

        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    /*[DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}

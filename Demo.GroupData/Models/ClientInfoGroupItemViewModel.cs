using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GroupData.Models
{
    public class ClientInfoGroupItemViewModel : GroupItemModelBase
    {
        public ClientInfoGroupItemViewModel(clientInfoType clientInfoOlder, clientInfoType clientInfoNew)
            : base(clientInfoOlder.Id, true)
        {
            this.clientInfoOlder = clientInfoOlder;
            this.clientInfoNew = clientInfoNew;
            this.InitData();
        }
        public clientInfoType ClientInfoOlder
        {
            get
            {
                return this.clientInfoOlder;
            }
            set
            {
                this.clientInfoOlder = value;
            }
        }
        private clientInfoType clientInfoOlder;

        public clientInfoType ClientInfoNew
        {
            get
            {
                return this.clientInfoNew;
            }
            set
            {
                this.clientInfoNew = value;
            }
        }
        private clientInfoType clientInfoNew;

        private void InitData()
        {
            this.CreateDataItem("Title", clientInfoOlder.title ,  clientInfoNew.title);
            this.CreateDataItem("Last Name", clientInfoOlder.lastName, clientInfoNew.lastName);
            this.CreateDataItem("First Name", clientInfoOlder.firstName, clientInfoNew.firstName);
            this.CreateDataItem("Supplement", clientInfoOlder.supplement, clientInfoNew.supplement);
            this.CreateDataItem("Street", clientInfoOlder.street, clientInfoNew.street);
            //Post Code Place
            this.CreateDataItem("Post Code", clientInfoOlder.postcodePlace.postcode, clientInfoNew.postcodePlace.postcode);
            this.CreateDataItem("Place", clientInfoOlder.postcodePlace.place, clientInfoNew.postcodePlace.place);
            this.CreateDataItem("Canton", clientInfoOlder.postcodePlace.canton, clientInfoNew.postcodePlace.canton);

            this.CreateDataItem("Telephone P", clientInfoOlder.telephoneP, clientInfoNew.telephoneP);
            this.CreateDataItem("Telephone G", clientInfoOlder.telephoneG, clientInfoNew.telephoneG);
            this.CreateDataItem("Mobile", clientInfoOlder.mobile, clientInfoNew.mobile);
            this.CreateDataItem("Email", clientInfoOlder.email, clientInfoNew.email);
            // Registered Residence
            this.CreateDataItem("Registered Residence - Post Code", clientInfoOlder.registeredResidence.postcode, clientInfoNew.registeredResidence.postcode);
            this.CreateDataItem("Registered Residence - Place", clientInfoOlder.registeredResidence.place, clientInfoNew.registeredResidence.place);
            this.CreateDataItem("Registered Residence - Canton", clientInfoOlder.registeredResidence.canton, clientInfoNew.registeredResidence.canton);

            this.CreateDataItem("Address", clientInfoOlder.address, clientInfoNew.address);
            this.CreateDataItem("Sex", clientInfoOlder.sex, clientInfoNew.sex);
            this.CreateDataItem("Marital Status", clientInfoOlder.maritalStatus, clientInfoNew.maritalStatus);
            this.CreateDataItem("Confession", clientInfoOlder.confession, clientInfoNew.confession);
            this.CreateDataItem("Date Of Birth", clientInfoOlder.dateOfBirth, clientInfoNew.dateOfBirth);
            this.CreateDataItem("Nnss", clientInfoOlder.nnss, clientInfoNew.nnss);
            // Hometown
            this.CreateDataItem("Hometown - Post Code", clientInfoOlder.hometown.postcode, clientInfoNew.hometown.postcode);
            this.CreateDataItem("Hometown - Place", clientInfoOlder.hometown.place, clientInfoNew.hometown.place);
            this.CreateDataItem("Hometown - Canton", clientInfoOlder.hometown.canton, clientInfoNew.hometown.canton);

            this.CreateDataItem("Nationality", clientInfoOlder.nationality, clientInfoNew.nationality);
            // Responsible Person
            this.CreateDataItem("Responsible Person - FirstName", clientInfoOlder.responsiblePerson.firstName, clientInfoNew.responsiblePerson.firstName);
            this.CreateDataItem("Responsible Person - LastName", clientInfoOlder.responsiblePerson.lastName, clientInfoNew.responsiblePerson.lastName);

            // Client Case
            this.CreateDataItem("Client Case - Subject Area", clientInfoOlder.clientCase.subjectArea, clientInfoNew.clientCase.subjectArea);
            this.CreateDataItem("Client Case - Anamnesis", clientInfoOlder.clientCase.anamnesis, clientInfoNew.clientCase.anamnesis);
            this.CreateDataItem("Client Case - Responsible Community - Post Code", clientInfoOlder.clientCase.responsibleCommunity.postcode, clientInfoNew.clientCase.responsibleCommunity.postcode);
            this.CreateDataItem("Client Case - Responsible Community - Place", clientInfoOlder.clientCase.responsibleCommunity.place, clientInfoNew.clientCase.responsibleCommunity.place);
            this.CreateDataItem("Client Case - Responsible Community - Canton", clientInfoOlder.clientCase.responsibleCommunity.canton, clientInfoNew.clientCase.responsibleCommunity.canton);
        }

        private void CreateDataItem(string propName, dynamic propValueOlder, dynamic propValueNew)
        {
            var dataOlder = propValueOlder != null ? propValueOlder.ToString() : string.Empty;
            var dataNew = propValueNew != null ? propValueNew.ToString() : string.Empty;
            var useFirst = !string.IsNullOrEmpty(dataOlder) ? true : !string.IsNullOrEmpty(dataNew) ? false : (bool?)null;
            this.Items.Add(new DataItemViewModelBase(this.Id, propName, dataOlder, dataNew, useFirst, clientInfoOlder, clientInfoNew));
        }
    }
}

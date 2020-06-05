using System.Runtime.Serialization;

namespace GitHub.DistributedTask.WebApi
{
    [DataContract]
    public class ActionDownloadInfo
    {
        [DataMember]
        public string NameWithOwner
        {
            get;
            set;
        }

        [DataMember]
        public string Ref
        {
            get;
            set;
        }

        [DataMember]
        public string TarballUrl
        {
            get;
            set;
        }

        [DataMember]
        public string Token
        {
            get;
            set;
        }

        [DataMember]
        public string ZipballUrl
        {
            get;
            set;
        }
    }
}

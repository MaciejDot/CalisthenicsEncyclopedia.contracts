using System;
using System.Collections.Generic;
using System.Text;

namespace CalisthenicsEncyclpoedia.Contracts.Events
{
    public interface IAddedUserEvent
    {
        public string Id { get; set; }
        public string Username { get; set; }
    }
}

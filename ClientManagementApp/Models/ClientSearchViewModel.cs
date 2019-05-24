using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientManagementApplication.Models
{
    public class ClientSearchViewModel
    {
        public List<Client> Clients { get; set; }
        public SelectList FirstNames { get; set; }
        public string FirstName { get; set; }
        public string SearchString { get; set; }
    }
}

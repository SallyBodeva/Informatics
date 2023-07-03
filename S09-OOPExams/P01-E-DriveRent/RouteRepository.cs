using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace P01_E_DriveRent
{
    public class RouteRepository : IRepository<Route>
    {
        private readonly List<Route> routes;
        public RouteRepository()
        {
            this.routes = new List<Route>();
        }
        public ReadOnlyCollection<Route> Routes
        {
            get { return this.routes.AsReadOnly(); }
        }
        public void AddModel(Route model)
        {
            this.routes.Add(model);
        }

        public Route FindById(string identifier)
        {
            var r = this.routes.FirstOrDefault(x => x.RouteId == int.Parse(identifier));
            return r;
        }

        public IReadOnlyCollection<Route> GetAll()
        {
            return Routes;
        }

        public bool RemoveById(string identifier)
        {
            return this.routes.Remove(this.routes.FirstOrDefault(x=>x.RouteId==int.Parse(identifier)));
        }
    }
}

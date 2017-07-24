using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Routing.Models.Identity;
using IdentityConsoleApplication.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Routing.Services
{
    public class UserServiceController : ApiController
    {
        static UserRepository _userRepository = new UserRepository();

        // GET api/userservice
        public JToken Get()
        {
            IEnumerable<User> userlist = _userRepository.GetAll();
            return JsonConvert.SerializeObject(userlist);
 
        }

        // GET api/userservice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/userservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/userservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/userservice/5
        public void Delete(int id)
        {
        }
    }
}

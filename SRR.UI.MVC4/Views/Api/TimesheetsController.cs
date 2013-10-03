using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using SRR.UI.MVC4.Models;

namespace SRR.UI.MVC4.Views.Api
{
    public class TimesheetsController : ApiController
    {
        private static readonly List<TimeSheet> _repository = new List<TimeSheet>();

        public TimesheetsController()
        {
            _repository.Add(new TimeSheet() 
            {
                ID = "95",
                FirstName = "Imre",
                LastName = "Turi",
                Month = 8,
                Year = 1987
            });

            //var connectionString = ConfigurationManager.AppSettings["MongoDBTimesheets"];
            //_mongoDb = MongoDatabase.Create(connectionString);

            //_repository = _mongoDb.GetCollection<Timesheet>(typeof(Timesheet).Name);
        }

        // GET /api/timesheets
        public HttpResponseMessage Get()
        {
            var timesheets = _repository;
            var response = Request.CreateResponse(HttpStatusCode.OK, timesheets);
            string uri = Url.Route(null, null);
            response.Headers.Location = new Uri(Request.RequestUri, uri);
            return response;
        }

        // GET /api/timesheets/4fd63a86f65e0a0e84e510de
        [HttpGet]
        public TimeSheet Get(string id)
        {
            return _repository.Where(p => p.ID == id).FirstOrDefault();

            //var query = Query.EQ("_id", new ObjectId(id));
            //return _repo.Where(p => p.Id = query).FirstOrDefault();

            //var query = Query.EQ("_id", new ObjectId(id));
            //return _repository.Find(query).Single();
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        // POST /api/timesheets
        [HttpPost]
        public HttpResponseMessage Post(TimeSheet timesheet)
        {
            timesheet.ID = RandomString(10);
            //_repository.Insert(timesheet);
            _repository.Add(timesheet);
            string uri = Url.Route(null, new { id = timesheet.ID }); // Where is the new timesheet?
            var response = Request.CreateResponse(HttpStatusCode.Created, timesheet);
            response.Headers.Location = new Uri(Request.RequestUri, uri);
            return response;
        }

        // PUT /api/timesheets
        [HttpPut]
        public HttpResponseMessage Put(TimeSheet timesheet)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, timesheet);
            //_repository.Save(timesheet);
            if (_repository.Where(p => p.ID == timesheet.ID).Any())
            {
                int index = _repository.FindIndex(p => p.ID == timesheet.ID);
                _repository[index] = timesheet;
            }
            else
            {
                string gg = "";
            }

            string uri = Url.Route(null, new { id = timesheet.ID }); // Where is the modified timesheet?
            response.Headers.Location = new Uri(Request.RequestUri, uri);
            return response;
        }

        // DELETE /api/timesheets/4fd63a86f65e0a0e84e510de
        public HttpResponseMessage Delete(params string[] ids)
        {
            //foreach (var id in ids)
            //{
            //    _repository.Remove(Query.EQ("_id", new ObjectId(id)));
            //}
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}

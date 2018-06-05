using Microsoft.AspNetCore.Mvc;
using System;

namespace PalTracker
{
    public class TimeEntryController : Controller
    {
        
        public TimeEntryController(object obj)
        {
            throw new NotImplementedException();
        }

         public object Read(int x)
         {
             throw new NotImplementedException();
         }

        public void Read_NotFound()
        {
             throw new NotImplementedException();
        }

        public object Create(TimeEntry t)
        {
            throw new NotImplementedException();
        }

        public object List()
        {
             throw new NotImplementedException();
        }

        public object Update(int x, TimeEntry update)
        {
            throw new NotImplementedException();  

        }

        public void Update_NotFound()
        {
             throw new NotImplementedException();
        }

        public object Delete(int x)
        { 
            throw new NotImplementedException();
        }


        public void Delete_NotFound()
        {
             throw new NotImplementedException();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Initialization;

namespace Akelon.HelpDesk.Server
{
  public partial class ModuleInitializer
  {

    public override void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
    {
      CreateRequestRecord();
    }

    /// <summary>
    /// 
    /// </summary>
    public void CreateRequestRecord()
    { 
      var temp = Sungero.Company.Employees.GetAll().Where(e => e.Login.LoginName == "Radion");
      if (!HelpDesk.InternalRequests.GetAll().Where(e => e.Author.Login.LoginName == "Radion").Any())
      {
        var Ref = HelpDesk.InternalRequests.Create();
        foreach(var p in Ref.State.Properties.Where(r => r.IsRequired))
        {
          p.IsRequired = false;
        }
        
        Ref.Name = "тестовая запись";
        Ref.Number = 10;
        Ref.CreatedDate = Calendar.Today;
        Ref.Author = Sungero.Company.Employees.GetAll().Where(e => e.Login.LoginName == "Radion").FirstOrDefault();
        Ref.Save();
      }
      
      
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.Request;

namespace Akelon.HelpDesk.Server
{
  partial class RequestFunctions
  {

    /// <summary>
    /// Создать связанный с обращением документ.
    /// </summary>
    [Remote]
    public IAddendumRequest CreateAddendumRequest()
    {
      var document = AddendumRequests.Create();
      document.Request = _obj;
      document.Name = string.Format("Приложение к обращению № {0}", _obj.Number);
      if (!document.AccessRights.IsGranted(DefaultAccessRightsTypes.Change, _obj.Responsible))
      {
        document.AccessRights.Grant(_obj.Responsible, DefaultAccessRightsTypes.Change);
      }
        return document;
    }

    /// <summary>
    /// 
    /// </summary>
    public void FillingProperties()
    {
      _obj.Number = _obj.Id;
      _obj.CreatedDate = Calendar.Today;
      _obj.Name = "Обращение №"  + _obj.Number;
      _obj.Responsible = Sungero.Company.Employees.Current;
      _obj.LifeCycle = Akelon.HelpDesk.Request.LifeCycle.InWork;
      
    }

  }
}
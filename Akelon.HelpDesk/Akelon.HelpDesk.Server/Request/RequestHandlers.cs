using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.Request;

namespace Akelon.HelpDesk
{
  partial class RequestServerHandlers
  {

    public override void BeforeDelete(Sungero.Domain.BeforeDeleteEventArgs e)
    {
      var Number = _obj.Number;
      var Subject = "\"" + _obj.Name + "\"";
      var CurrentUserID = Sungero.Company.Employees.Current.Id;
      var Log = string.Format("Пользователь 1234567 ИД = {0} удалил обращение номер: {1} тема {2}", CurrentUserID, Number, Subject);
      Logger.Debug(Log);
    }

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      Functions.Request.FillingProperties(_obj);
      //_obj.Number = _obj.Id;
      //_obj.CreatedDate = Calendar.Today;
      //_obj.Name = "Обращение №"  + _obj.Number;
      //_obj.Responsible = Sungero.Company.Employees.Current;
      //_obj.LifeCycle = Akelon.HelpDesk.Request.LifeCycle.InWork;
      
    }

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      if (_obj.LifeCycle == HelpDesk.Request.LifeCycle.Closed)
      {
        _obj.ClosedDate = Calendar.Today;
      }
      
      if (_obj.LifeCycle == LifeCycle.Closed && string.IsNullOrEmpty(_obj.Result))
      {
        e.AddError("Перед закрытием обращения заполните результат.");
      }
      
      
      
      e.AddInformation("Проверка");
      
      
    }
  }

}
using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.RequestKind;

namespace Akelon.HelpDesk
{
  partial class RequestKindServerHandlers
  {

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      if (_obj.Note.Length < 5)
      {
        e.AddError("Длинна примечания должна быть больше пяти символов.");
      }
        
    }
    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
    }

    public override void AfterSave(Sungero.Domain.AfterSaveEventArgs e)
    {
    }
  }

}
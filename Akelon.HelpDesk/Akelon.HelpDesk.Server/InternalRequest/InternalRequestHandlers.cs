using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.InternalRequest;

namespace Akelon.HelpDesk
{
  partial class InternalRequestServerHandlers
  {

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      base.Created(e);
      _obj.Author = Sungero.Company.Employees.Current;
    }
  }

}
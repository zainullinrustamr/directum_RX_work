using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Akelon.HelpDesk.Server
{
  public class ModuleFunctions
  {

    /// <summary>
    /// 
    /// </summary>
    [ExpressionElement("Показать ссылку")]
    public static Sungero.CoreEntities.IRecipient СEOofAuthor(Sungero.Workflow.ITask task)
    {
      return Sungero.Company.Employees.Get(task.Author.Id).Department.BusinessUnit.CEO;
    }
    public void CreateRequestRecord()
    {
    }

  }
}
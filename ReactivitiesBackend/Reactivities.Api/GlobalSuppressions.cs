// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("CRUD Pattern", "PR1003:PeopleReady: ApiControllers must implement the BaseController, BaseCRUDController or BaseRelationalCRUDController classes", Justification = "<Pending>", Scope = "type", Target = "~T:Reactivities.Api.Controllers.ValuesController")]
[assembly: SuppressMessage("Code Quality", "PR2004:PeopleReady: Async methods must have an Async suffix in their names", Justification = "<Pending>", Scope = "member", Target = "~M:Reactivities.Api.Controllers.ValuesController.Get~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{System.Collections.Generic.IEnumerable{Reactivities.Domain.Value}}}")]
[assembly: SuppressMessage("Code Quality", "PR2004:PeopleReady: Async methods must have an Async suffix in their names", Justification = "<Pending>", Scope = "member", Target = "~M:Reactivities.Api.Controllers.ValuesController.Get(System.Int32)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{Reactivities.Domain.Value}}")]

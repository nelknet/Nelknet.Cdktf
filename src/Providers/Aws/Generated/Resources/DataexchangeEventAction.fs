namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataexchangeEventActionState = { assignments: ResizeArray<aws.DataexchangeEventAction.DataexchangeEventActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action">aws_dataexchange_event_action</a>.
    /// </summary>
    type DataexchangeEventActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataexchangeEventActionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataexchangeEventActionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#action-1">DataexchangeEventAction#action</a> Accepts: aws.IResolvable | aws.DataexchangeEventAction.DataexchangeEventActionAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: DataexchangeEventActionState, value: HashiCorp.Cdktf.IResolvable) : DataexchangeEventActionState =
            state.assignments.Add(fun config -> config.Action <- value)
            state : DataexchangeEventActionState

        /// <summary>
        /// event block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#event-1">DataexchangeEventAction#event</a> Accepts: aws.IResolvable | aws.DataexchangeEventAction.DataexchangeEventActionEvent[]
        /// </summary>
        [<CustomOperation "event">]
        member _.Event(state: DataexchangeEventActionState, value: HashiCorp.Cdktf.IResolvable) : DataexchangeEventActionState =
            state.assignments.Add(fun config -> config.Event <- value)
            state : DataexchangeEventActionState

        member _.Run(state: DataexchangeEventActionState) : aws.DataexchangeEventAction.DataexchangeEventAction =
            let config = aws.DataexchangeEventAction.DataexchangeEventActionConfig()
            for setter in state.assignments do
                setter config
            aws.DataexchangeEventAction.DataexchangeEventAction(StackContext.get (), logicalId, config)

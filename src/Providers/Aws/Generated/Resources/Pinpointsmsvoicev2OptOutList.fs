namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Pinpointsmsvoicev2OptOutListState<'Name> = { assignments: ResizeArray<aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_opt_out_list">aws_pinpointsmsvoicev2_opt_out_list</a>.
    /// </summary>
    type Pinpointsmsvoicev2OptOutListBuilder(logicalId: string) =
        member _.Yield(_: unit) : Pinpointsmsvoicev2OptOutListState<Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2OptOutListState<Missing>)

        member _.Zero(()) : Pinpointsmsvoicev2OptOutListState<Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2OptOutListState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_opt_out_list#name-1">Pinpointsmsvoicev2OptOutList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Pinpointsmsvoicev2OptOutListState<Missing>, value: string) : Pinpointsmsvoicev2OptOutListState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Pinpointsmsvoicev2OptOutListState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_opt_out_list#tags-1">Pinpointsmsvoicev2OptOutList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Pinpointsmsvoicev2OptOutListState<'Name>, value: seq<string * string>) : Pinpointsmsvoicev2OptOutListState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Pinpointsmsvoicev2OptOutListState<'Name>

        member _.Run(state: Pinpointsmsvoicev2OptOutListState<Present>) : aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutList =
            let config = aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutListConfig()
            for setter in state.assignments do
                setter config
            aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointsmsvoicev2OptOutList: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Pinpointsmsvoicev2OptOutListState<_>) : aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutList =
            Unchecked.defaultof<aws.Pinpointsmsvoicev2OptOutList.Pinpointsmsvoicev2OptOutList>

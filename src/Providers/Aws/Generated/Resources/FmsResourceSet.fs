namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FmsResourceSetState = { assignments: ResizeArray<aws.FmsResourceSet.FmsResourceSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set">aws_fms_resource_set</a>.
    /// </summary>
    type FmsResourceSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : FmsResourceSetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : FmsResourceSetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// resource_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#resource_set-1">FmsResourceSet#resource_set</a> Accepts: aws.IResolvable | aws.FmsResourceSet.FmsResourceSetResourceSet[]
        /// </summary>
        [<CustomOperation "resource_set">]
        member _.ResourceSet(state: FmsResourceSetState, value: HashiCorp.Cdktf.IResolvable) : FmsResourceSetState =
            state.assignments.Add(fun config -> config.ResourceSet <- value)
            state : FmsResourceSetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#tags-1">FmsResourceSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FmsResourceSetState, value: seq<string * string>) : FmsResourceSetState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FmsResourceSetState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_resource_set#timeouts-1">FmsResourceSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FmsResourceSetState, value: aws.FmsResourceSet.FmsResourceSetTimeouts) : FmsResourceSetState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FmsResourceSetState

        member _.Run(state: FmsResourceSetState) : aws.FmsResourceSet.FmsResourceSet =
            let config = aws.FmsResourceSet.FmsResourceSetConfig()
            for setter in state.assignments do
                setter config
            aws.FmsResourceSet.FmsResourceSet(StackContext.get (), logicalId, config)

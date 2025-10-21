namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Inspector2EnablerState<'AccountIds, 'ResourceTypes> = { assignments: ResizeArray<aws.Inspector2Enabler.Inspector2EnablerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_enabler">aws_inspector2_enabler</a>.
    /// </summary>
    type Inspector2EnablerBuilder(logicalId: string) =
        member _.Yield(_: unit) : Inspector2EnablerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Inspector2EnablerState<Missing, Missing>)

        member _.Zero(()) : Inspector2EnablerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Inspector2EnablerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_enabler#account_ids-1">Inspector2Enabler#account_ids</a>.
        /// </summary>
        [<CustomOperation "account_ids">]
        member _.AccountIds(state: Inspector2EnablerState<Missing, 'ResourceTypes>, value: seq<string>) : Inspector2EnablerState<Present, 'ResourceTypes> =
            state.assignments.Add(fun config -> config.AccountIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Inspector2EnablerState<Present, 'ResourceTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_enabler#resource_types-1">Inspector2Enabler#resource_types</a>.
        /// </summary>
        [<CustomOperation "resource_types">]
        member _.ResourceTypes(state: Inspector2EnablerState<'AccountIds, Missing>, value: seq<string>) : Inspector2EnablerState<'AccountIds, Present> =
            state.assignments.Add(fun config -> config.ResourceTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Inspector2EnablerState<'AccountIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_enabler#id-1">Inspector2Enabler#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Inspector2EnablerState<'AccountIds, 'ResourceTypes>, value: string) : Inspector2EnablerState<'AccountIds, 'ResourceTypes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Inspector2EnablerState<'AccountIds, 'ResourceTypes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_enabler#timeouts-1">Inspector2Enabler#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Inspector2EnablerState<'AccountIds, 'ResourceTypes>, value: aws.Inspector2Enabler.Inspector2EnablerTimeouts) : Inspector2EnablerState<'AccountIds, 'ResourceTypes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Inspector2EnablerState<'AccountIds, 'ResourceTypes>

        member _.Run(state: Inspector2EnablerState<Present, Present>) : aws.Inspector2Enabler.Inspector2Enabler =
            let config = aws.Inspector2Enabler.Inspector2EnablerConfig()
            for setter in state.assignments do
                setter config
            aws.Inspector2Enabler.Inspector2Enabler(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspector2Enabler: missing required arguments. Must call: account_ids, resource_types.", 9999, IsError = true)>]
        member _.Run(_: Inspector2EnablerState<_, _>) : aws.Inspector2Enabler.Inspector2Enabler =
            Unchecked.defaultof<aws.Inspector2Enabler.Inspector2Enabler>

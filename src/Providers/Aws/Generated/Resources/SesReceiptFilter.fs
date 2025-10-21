namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesReceiptFilterState<'Cidr, 'Name, 'Policy> = { assignments: ResizeArray<aws.SesReceiptFilter.SesReceiptFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_filter">aws_ses_receipt_filter</a>.
    /// </summary>
    type SesReceiptFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesReceiptFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesReceiptFilterState<Missing, Missing, Missing>)

        member _.Zero(()) : SesReceiptFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesReceiptFilterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_filter#cidr-1">SesReceiptFilter#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: SesReceiptFilterState<Missing, 'Name, 'Policy>, value: string) : SesReceiptFilterState<Present, 'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            ({ assignments = state.assignments } : SesReceiptFilterState<Present, 'Name, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_filter#name-1">SesReceiptFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesReceiptFilterState<'Cidr, Missing, 'Policy>, value: string) : SesReceiptFilterState<'Cidr, Present, 'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesReceiptFilterState<'Cidr, Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_filter#policy-1">SesReceiptFilter#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SesReceiptFilterState<'Cidr, 'Name, Missing>, value: string) : SesReceiptFilterState<'Cidr, 'Name, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SesReceiptFilterState<'Cidr, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_filter#id-1">SesReceiptFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesReceiptFilterState<'Cidr, 'Name, 'Policy>, value: string) : SesReceiptFilterState<'Cidr, 'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesReceiptFilterState<'Cidr, 'Name, 'Policy>

        member _.Run(state: SesReceiptFilterState<Present, Present, Present>) : aws.SesReceiptFilter.SesReceiptFilter =
            let config = aws.SesReceiptFilter.SesReceiptFilterConfig()
            for setter in state.assignments do
                setter config
            aws.SesReceiptFilter.SesReceiptFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesReceiptFilter: missing required arguments. Must call: cidr, name, policy.", 9999, IsError = true)>]
        member _.Run(_: SesReceiptFilterState<_, _, _>) : aws.SesReceiptFilter.SesReceiptFilter =
            Unchecked.defaultof<aws.SesReceiptFilter.SesReceiptFilter>

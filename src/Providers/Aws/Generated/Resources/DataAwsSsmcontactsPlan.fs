namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmcontactsPlanState<'ContactId> = { assignments: ResizeArray<aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_plan">aws_ssmcontacts_plan</a>.
    /// </summary>
    type DataAwsSsmcontactsPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmcontactsPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsPlanState<Missing>)

        member _.Zero(()) : DataAwsSsmcontactsPlanState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsPlanState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_plan#contact_id-1">DataAwsSsmcontactsPlan#contact_id</a>.
        /// </summary>
        [<CustomOperation "contact_id">]
        member _.ContactId(state: DataAwsSsmcontactsPlanState<Missing>, value: string) : DataAwsSsmcontactsPlanState<Present> =
            state.assignments.Add(fun config -> config.ContactId <- value)
            ({ assignments = state.assignments } : DataAwsSsmcontactsPlanState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_plan#id-1">DataAwsSsmcontactsPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsmcontactsPlanState<'ContactId>, value: string) : DataAwsSsmcontactsPlanState<'ContactId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsmcontactsPlanState<'ContactId>

        member _.Run(state: DataAwsSsmcontactsPlanState<Present>) : aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlan =
            let config = aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlanConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmcontactsPlan: missing required arguments. Must call: contact_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmcontactsPlanState<_>) : aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlan =
            Unchecked.defaultof<aws.DataAwsSsmcontactsPlan.DataAwsSsmcontactsPlan>

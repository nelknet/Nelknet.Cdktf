namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmcontactsPlanState<'ContactId, 'Stage> = { assignments: ResizeArray<aws.SsmcontactsPlan.SsmcontactsPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan">aws_ssmcontacts_plan</a>.
    /// </summary>
    type SsmcontactsPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmcontactsPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsPlanState<Missing, Missing>)

        member _.Zero(()) : SsmcontactsPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsPlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_id-1">SsmcontactsPlan#contact_id</a>.
        /// </summary>
        [<CustomOperation "contact_id">]
        member _.ContactId(state: SsmcontactsPlanState<Missing, 'Stage>, value: string) : SsmcontactsPlanState<Present, 'Stage> =
            state.assignments.Add(fun config -> config.ContactId <- value)
            ({ assignments = state.assignments } : SsmcontactsPlanState<Present, 'Stage>)

        /// <summary>
        /// stage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#stage-1">SsmcontactsPlan#stage</a> Accepts: aws.IResolvable | aws.SsmcontactsPlan.SsmcontactsPlanStage[]
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: SsmcontactsPlanState<'ContactId, Missing>, value: HashiCorp.Cdktf.IResolvable) : SsmcontactsPlanState<'ContactId, Present> =
            state.assignments.Add(fun config -> config.Stage <- value)
            ({ assignments = state.assignments } : SsmcontactsPlanState<'ContactId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#id-1">SsmcontactsPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmcontactsPlanState<'ContactId, 'Stage>, value: string) : SsmcontactsPlanState<'ContactId, 'Stage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmcontactsPlanState<'ContactId, 'Stage>

        member _.Run(state: SsmcontactsPlanState<Present, Present>) : aws.SsmcontactsPlan.SsmcontactsPlan =
            let config = aws.SsmcontactsPlan.SsmcontactsPlanConfig()
            for setter in state.assignments do
                setter config
            aws.SsmcontactsPlan.SsmcontactsPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmcontactsPlan: missing required arguments. Must call: contact_id, stage.", 9999, IsError = true)>]
        member _.Run(_: SsmcontactsPlanState<_, _>) : aws.SsmcontactsPlan.SsmcontactsPlan =
            Unchecked.defaultof<aws.SsmcontactsPlan.SsmcontactsPlan>

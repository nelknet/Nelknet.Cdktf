namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2AccountVdmAttributesState<'VdmEnabled> = { assignments: ResizeArray<aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes">aws_sesv2_account_vdm_attributes</a>.
    /// </summary>
    type Sesv2AccountVdmAttributesBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2AccountVdmAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2AccountVdmAttributesState<Missing>)

        member _.Zero(()) : Sesv2AccountVdmAttributesState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2AccountVdmAttributesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#vdm_enabled-1">Sesv2AccountVdmAttributes#vdm_enabled</a>.
        /// </summary>
        [<CustomOperation "vdm_enabled">]
        member _.VdmEnabled(state: Sesv2AccountVdmAttributesState<Missing>, value: string) : Sesv2AccountVdmAttributesState<Present> =
            state.assignments.Add(fun config -> config.VdmEnabled <- value)
            ({ assignments = state.assignments } : Sesv2AccountVdmAttributesState<Present>)

        /// <summary>
        /// dashboard_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#dashboard_attributes-1">Sesv2AccountVdmAttributes#dashboard_attributes</a>
        /// </summary>
        [<CustomOperation "dashboard_attributes">]
        member _.DashboardAttributes(state: Sesv2AccountVdmAttributesState<'VdmEnabled>, value: aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesDashboardAttributes) : Sesv2AccountVdmAttributesState<'VdmEnabled> =
            state.assignments.Add(fun config -> config.DashboardAttributes <- value)
            state : Sesv2AccountVdmAttributesState<'VdmEnabled>

        /// <summary>
        /// guardian_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#guardian_attributes-1">Sesv2AccountVdmAttributes#guardian_attributes</a>
        /// </summary>
        [<CustomOperation "guardian_attributes">]
        member _.GuardianAttributes(state: Sesv2AccountVdmAttributesState<'VdmEnabled>, value: aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesGuardianAttributes) : Sesv2AccountVdmAttributesState<'VdmEnabled> =
            state.assignments.Add(fun config -> config.GuardianAttributes <- value)
            state : Sesv2AccountVdmAttributesState<'VdmEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#id-1">Sesv2AccountVdmAttributes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2AccountVdmAttributesState<'VdmEnabled>, value: string) : Sesv2AccountVdmAttributesState<'VdmEnabled> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2AccountVdmAttributesState<'VdmEnabled>

        member _.Run(state: Sesv2AccountVdmAttributesState<Present>) : aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributes =
            let config = aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2AccountVdmAttributes: missing required arguments. Must call: vdm_enabled.", 9999, IsError = true)>]
        member _.Run(_: Sesv2AccountVdmAttributesState<_>) : aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributes =
            Unchecked.defaultof<aws.Sesv2AccountVdmAttributes.Sesv2AccountVdmAttributes>

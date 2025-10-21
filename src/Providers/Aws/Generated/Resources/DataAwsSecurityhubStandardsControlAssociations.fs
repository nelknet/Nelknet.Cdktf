namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecurityhubStandardsControlAssociationsState<'SecurityControlId> = { assignments: ResizeArray<aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/securityhub_standards_control_associations">aws_securityhub_standards_control_associations</a>.
    /// </summary>
    type DataAwsSecurityhubStandardsControlAssociationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecurityhubStandardsControlAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecurityhubStandardsControlAssociationsState<Missing>)

        member _.Zero(()) : DataAwsSecurityhubStandardsControlAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecurityhubStandardsControlAssociationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/securityhub_standards_control_associations#security_control_id-1">DataAwsSecurityhubStandardsControlAssociations#security_control_id</a>.
        /// </summary>
        [<CustomOperation "security_control_id">]
        member _.SecurityControlId(state: DataAwsSecurityhubStandardsControlAssociationsState<Missing>, value: string) : DataAwsSecurityhubStandardsControlAssociationsState<Present> =
            state.assignments.Add(fun config -> config.SecurityControlId <- value)
            ({ assignments = state.assignments } : DataAwsSecurityhubStandardsControlAssociationsState<Present>)

        member _.Run(state: DataAwsSecurityhubStandardsControlAssociationsState<Present>) : aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociations =
            let config = aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSecurityhubStandardsControlAssociations: missing required arguments. Must call: security_control_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSecurityhubStandardsControlAssociationsState<_>) : aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociations =
            Unchecked.defaultof<aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociations>

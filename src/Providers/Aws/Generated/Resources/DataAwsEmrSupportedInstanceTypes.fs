namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEmrSupportedInstanceTypesState<'ReleaseLabel> = { assignments: ResizeArray<aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_supported_instance_types">aws_emr_supported_instance_types</a>.
    /// </summary>
    type DataAwsEmrSupportedInstanceTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEmrSupportedInstanceTypesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEmrSupportedInstanceTypesState<Missing>)

        member _.Zero(()) : DataAwsEmrSupportedInstanceTypesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEmrSupportedInstanceTypesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_supported_instance_types#release_label-1">DataAwsEmrSupportedInstanceTypes#release_label</a>.
        /// </summary>
        [<CustomOperation "release_label">]
        member _.ReleaseLabel(state: DataAwsEmrSupportedInstanceTypesState<Missing>, value: string) : DataAwsEmrSupportedInstanceTypesState<Present> =
            state.assignments.Add(fun config -> config.ReleaseLabel <- value)
            ({ assignments = state.assignments } : DataAwsEmrSupportedInstanceTypesState<Present>)

        /// <summary>
        /// supported_instance_types block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_supported_instance_types#supported_instance_types-1">DataAwsEmrSupportedInstanceTypes#supported_instance_types</a> Accepts: aws.IResolvable | aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesSupportedInstanceTypes[]
        /// </summary>
        [<CustomOperation "supported_instance_types">]
        member _.SupportedInstanceTypes(state: DataAwsEmrSupportedInstanceTypesState<'ReleaseLabel>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEmrSupportedInstanceTypesState<'ReleaseLabel> =
            state.assignments.Add(fun config -> config.SupportedInstanceTypes <- value)
            state : DataAwsEmrSupportedInstanceTypesState<'ReleaseLabel>

        member _.Run(state: DataAwsEmrSupportedInstanceTypesState<Present>) : aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypes =
            let config = aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEmrSupportedInstanceTypes: missing required arguments. Must call: release_label.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEmrSupportedInstanceTypesState<_>) : aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypes =
            Unchecked.defaultof<aws.DataAwsEmrSupportedInstanceTypes.DataAwsEmrSupportedInstanceTypes>

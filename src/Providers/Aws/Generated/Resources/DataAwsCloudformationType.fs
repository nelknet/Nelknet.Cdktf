namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudformationTypeState = { assignments: ResizeArray<aws.DataAwsCloudformationType.DataAwsCloudformationTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type">aws_cloudformation_type</a>.
    /// </summary>
    type DataAwsCloudformationTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudformationTypeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudformationTypeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type#arn-1">DataAwsCloudformationType#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsCloudformationTypeState, value: string) : DataAwsCloudformationTypeState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsCloudformationTypeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type#id-1">DataAwsCloudformationType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudformationTypeState, value: string) : DataAwsCloudformationTypeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudformationTypeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type#type-1">DataAwsCloudformationType#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsCloudformationTypeState, value: string) : DataAwsCloudformationTypeState =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataAwsCloudformationTypeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type#type_name-1">DataAwsCloudformationType#type_name</a>.
        /// </summary>
        [<CustomOperation "type_name">]
        member _.TypeName(state: DataAwsCloudformationTypeState, value: string) : DataAwsCloudformationTypeState =
            state.assignments.Add(fun config -> config.TypeName <- value)
            state : DataAwsCloudformationTypeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_type#version_id-1">DataAwsCloudformationType#version_id</a>.
        /// </summary>
        [<CustomOperation "version_id">]
        member _.VersionId(state: DataAwsCloudformationTypeState, value: string) : DataAwsCloudformationTypeState =
            state.assignments.Add(fun config -> config.VersionId <- value)
            state : DataAwsCloudformationTypeState

        member _.Run(state: DataAwsCloudformationTypeState) : aws.DataAwsCloudformationType.DataAwsCloudformationType =
            let config = aws.DataAwsCloudformationType.DataAwsCloudformationTypeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudformationType.DataAwsCloudformationType(StackContext.get (), logicalId, config)

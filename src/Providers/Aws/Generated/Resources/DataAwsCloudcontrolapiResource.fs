namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName> = { assignments: ResizeArray<aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource">aws_cloudcontrolapi_resource</a>.
    /// </summary>
    type DataAwsCloudcontrolapiResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudcontrolapiResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudcontrolapiResourceState<Missing, Missing>)

        member _.Zero(()) : DataAwsCloudcontrolapiResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudcontrolapiResourceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource#identifier-1">DataAwsCloudcontrolapiResource#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: DataAwsCloudcontrolapiResourceState<Missing, 'TypeName>, value: string) : DataAwsCloudcontrolapiResourceState<Present, 'TypeName> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : DataAwsCloudcontrolapiResourceState<Present, 'TypeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource#type_name-1">DataAwsCloudcontrolapiResource#type_name</a>.
        /// </summary>
        [<CustomOperation "type_name">]
        member _.TypeName(state: DataAwsCloudcontrolapiResourceState<'Identifier, Missing>, value: string) : DataAwsCloudcontrolapiResourceState<'Identifier, Present> =
            state.assignments.Add(fun config -> config.TypeName <- value)
            ({ assignments = state.assignments } : DataAwsCloudcontrolapiResourceState<'Identifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource#id-1">DataAwsCloudcontrolapiResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>, value: string) : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource#role_arn-1">DataAwsCloudcontrolapiResource#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>, value: string) : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudcontrolapi_resource#type_version_id-1">DataAwsCloudcontrolapiResource#type_version_id</a>.
        /// </summary>
        [<CustomOperation "type_version_id">]
        member _.TypeVersionId(state: DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>, value: string) : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName> =
            state.assignments.Add(fun config -> config.TypeVersionId <- value)
            state : DataAwsCloudcontrolapiResourceState<'Identifier, 'TypeName>

        member _.Run(state: DataAwsCloudcontrolapiResourceState<Present, Present>) : aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResource =
            let config = aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResourceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudcontrolapiResource: missing required arguments. Must call: identifier, type_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudcontrolapiResourceState<_, _>) : aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResource =
            Unchecked.defaultof<aws.DataAwsCloudcontrolapiResource.DataAwsCloudcontrolapiResource>

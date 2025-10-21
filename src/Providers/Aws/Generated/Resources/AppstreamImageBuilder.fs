namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamImageBuilderState<'InstanceType, 'Name> = { assignments: ResizeArray<aws.AppstreamImageBuilder.AppstreamImageBuilderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder">aws_appstream_image_builder</a>.
    /// </summary>
    type AppstreamImageBuilderBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamImageBuilderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamImageBuilderState<Missing, Missing>)

        member _.Zero(()) : AppstreamImageBuilderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamImageBuilderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#instance_type-1">AppstreamImageBuilder#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: AppstreamImageBuilderState<Missing, 'Name>, value: string) : AppstreamImageBuilderState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : AppstreamImageBuilderState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#name-1">AppstreamImageBuilder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppstreamImageBuilderState<'InstanceType, Missing>, value: string) : AppstreamImageBuilderState<'InstanceType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppstreamImageBuilderState<'InstanceType, Present>)

        /// <summary>
        /// access_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#access_endpoint-1">AppstreamImageBuilder#access_endpoint</a> Accepts: aws.IResolvable | aws.AppstreamImageBuilder.AppstreamImageBuilderAccessEndpoint[]
        /// </summary>
        [<CustomOperation "access_endpoint">]
        member _.AccessEndpoint(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.AccessEndpoint <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#appstream_agent_version-1">AppstreamImageBuilder#appstream_agent_version</a>.
        /// </summary>
        [<CustomOperation "appstream_agent_version">]
        member _.AppstreamAgentVersion(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.AppstreamAgentVersion <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#description-1">AppstreamImageBuilder#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#display_name-1">AppstreamImageBuilder#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// domain_join_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#domain_join_info-1">AppstreamImageBuilder#domain_join_info</a>
        /// </summary>
        [<CustomOperation "domain_join_info">]
        member _.DomainJoinInfo(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: aws.AppstreamImageBuilder.AppstreamImageBuilderDomainJoinInfo) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.DomainJoinInfo <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#enable_default_internet_access-1">AppstreamImageBuilder#enable_default_internet_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_internet_access">]
        member _.EnableDefaultInternetAccess(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: bool) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EnableDefaultInternetAccess <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#enable_default_internet_access-1">AppstreamImageBuilder#enable_default_internet_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_default_internet_access">]
        member _.EnableDefaultInternetAccess(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EnableDefaultInternetAccess <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#iam_role_arn-1">AppstreamImageBuilder#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#id-1">AppstreamImageBuilder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#image_arn-1">AppstreamImageBuilder#image_arn</a>.
        /// </summary>
        [<CustomOperation "image_arn">]
        member _.ImageArn(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ImageArn <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#image_name-1">AppstreamImageBuilder#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: string) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#tags-1">AppstreamImageBuilder#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: seq<string * string>) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#tags_all-1">AppstreamImageBuilder#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: seq<string * string>) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#vpc_config-1">AppstreamImageBuilder#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: AppstreamImageBuilderState<'InstanceType, 'Name>, value: aws.AppstreamImageBuilder.AppstreamImageBuilderVpcConfig) : AppstreamImageBuilderState<'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : AppstreamImageBuilderState<'InstanceType, 'Name>

        member _.Run(state: AppstreamImageBuilderState<Present, Present>) : aws.AppstreamImageBuilder.AppstreamImageBuilder =
            let config = aws.AppstreamImageBuilder.AppstreamImageBuilderConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamImageBuilder.AppstreamImageBuilder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamImageBuilder: missing required arguments. Must call: instance_type, name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamImageBuilderState<_, _>) : aws.AppstreamImageBuilder.AppstreamImageBuilder =
            Unchecked.defaultof<aws.AppstreamImageBuilder.AppstreamImageBuilder>

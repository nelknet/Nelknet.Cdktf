namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> = { assignments: ResizeArray<aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration">aws_imagebuilder_infrastructure_configuration</a>.
    /// </summary>
    type ImagebuilderInfrastructureConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderInfrastructureConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderInfrastructureConfigurationState<Missing, Missing>)

        member _.Zero(()) : ImagebuilderInfrastructureConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderInfrastructureConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#instance_profile_name-1">ImagebuilderInfrastructureConfiguration#instance_profile_name</a>.
        /// </summary>
        [<CustomOperation "instance_profile_name">]
        member _.InstanceProfileName(state: ImagebuilderInfrastructureConfigurationState<Missing, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceProfileName <- value)
            ({ assignments = state.assignments } : ImagebuilderInfrastructureConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#name-1">ImagebuilderInfrastructureConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, Missing>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#description-1">ImagebuilderInfrastructureConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#id-1">ImagebuilderInfrastructureConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// instance_metadata_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#instance_metadata_options-1">ImagebuilderInfrastructureConfiguration#instance_metadata_options</a>
        /// </summary>
        [<CustomOperation "instance_metadata_options">]
        member _.InstanceMetadataOptions(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationInstanceMetadataOptions) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.InstanceMetadataOptions <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#instance_types-1">ImagebuilderInfrastructureConfiguration#instance_types</a>.
        /// </summary>
        [<CustomOperation "instance_types">]
        member _.InstanceTypes(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: seq<string>) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.InstanceTypes <- (value |> Seq.toArray))
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#key_pair-1">ImagebuilderInfrastructureConfiguration#key_pair</a>.
        /// </summary>
        [<CustomOperation "key_pair">]
        member _.KeyPair(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.KeyPair <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// logging block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#logging-1">ImagebuilderInfrastructureConfiguration#logging</a>
        /// </summary>
        [<CustomOperation "logging">]
        member _.Logging(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLogging) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.Logging <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// placement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#placement-1">ImagebuilderInfrastructureConfiguration#placement</a>
        /// </summary>
        [<CustomOperation "placement">]
        member _.Placement(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationPlacement) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.Placement <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#resource_tags-1">ImagebuilderInfrastructureConfiguration#resource_tags</a>.
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: seq<string * string>) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.ResourceTags <- dict value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#security_group_ids-1">ImagebuilderInfrastructureConfiguration#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: seq<string>) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#sns_topic_arn-1">ImagebuilderInfrastructureConfiguration#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#subnet_id-1">ImagebuilderInfrastructureConfiguration#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: string) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#tags-1">ImagebuilderInfrastructureConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: seq<string * string>) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#tags_all-1">ImagebuilderInfrastructureConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: seq<string * string>) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#terminate_instance_on_failure-1">ImagebuilderInfrastructureConfiguration#terminate_instance_on_failure</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instance_on_failure">]
        member _.TerminateInstanceOnFailure(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: bool) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.TerminateInstanceOnFailure <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#terminate_instance_on_failure-1">ImagebuilderInfrastructureConfiguration#terminate_instance_on_failure</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instance_on_failure">]
        member _.TerminateInstanceOnFailure(state: ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name> =
            state.assignments.Add(fun config -> config.TerminateInstanceOnFailure <- value)
            state : ImagebuilderInfrastructureConfigurationState<'InstanceProfileName, 'Name>

        member _.Run(state: ImagebuilderInfrastructureConfigurationState<Present, Present>) : aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfiguration =
            let config = aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderInfrastructureConfiguration: missing required arguments. Must call: instance_profile_name, name.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderInfrastructureConfigurationState<_, _>) : aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfiguration =
            Unchecked.defaultof<aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfiguration>

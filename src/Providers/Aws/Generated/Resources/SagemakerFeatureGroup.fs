namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerFeatureGroup.SagemakerFeatureGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group">aws_sagemaker_feature_group</a>.
    /// </summary>
    type SagemakerFeatureGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerFeatureGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerFeatureGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerFeatureGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerFeatureGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#event_time_feature_name-1">SagemakerFeatureGroup#event_time_feature_name</a>.
        /// </summary>
        [<CustomOperation "event_time_feature_name">]
        member _.EventTimeFeatureName(state: SagemakerFeatureGroupState<Missing, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: string) : SagemakerFeatureGroupState<Present, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.EventTimeFeatureName <- value)
            ({ assignments = state.assignments } : SagemakerFeatureGroupState<Present, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>)

        /// <summary>
        /// feature_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_definition-1">SagemakerFeatureGroup#feature_definition</a> Accepts: aws.IResolvable | aws.SagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinition[]
        /// </summary>
        [<CustomOperation "feature_definition">]
        member _.FeatureDefinition(state: SagemakerFeatureGroupState<'EventTimeFeatureName, Missing, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : SagemakerFeatureGroupState<'EventTimeFeatureName, Present, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.FeatureDefinition <- value)
            ({ assignments = state.assignments } : SagemakerFeatureGroupState<'EventTimeFeatureName, Present, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_group_name-1">SagemakerFeatureGroup#feature_group_name</a>.
        /// </summary>
        [<CustomOperation "feature_group_name">]
        member _.FeatureGroupName(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, Missing, 'RecordIdentifierFeatureName, 'RoleArn>, value: string) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, Present, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.FeatureGroupName <- value)
            ({ assignments = state.assignments } : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, Present, 'RecordIdentifierFeatureName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#record_identifier_feature_name-1">SagemakerFeatureGroup#record_identifier_feature_name</a>.
        /// </summary>
        [<CustomOperation "record_identifier_feature_name">]
        member _.RecordIdentifierFeatureName(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, Missing, 'RoleArn>, value: string) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.RecordIdentifierFeatureName <- value)
            ({ assignments = state.assignments } : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#role_arn-1">SagemakerFeatureGroup#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, Missing>, value: string) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#description-1">SagemakerFeatureGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: string) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#id-1">SagemakerFeatureGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: string) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// offline_store_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#offline_store_config-1">SagemakerFeatureGroup#offline_store_config</a>
        /// </summary>
        [<CustomOperation "offline_store_config">]
        member _.OfflineStoreConfig(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: aws.SagemakerFeatureGroup.SagemakerFeatureGroupOfflineStoreConfig) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.OfflineStoreConfig <- value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// online_store_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#online_store_config-1">SagemakerFeatureGroup#online_store_config</a>
        /// </summary>
        [<CustomOperation "online_store_config">]
        member _.OnlineStoreConfig(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: aws.SagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfig) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.OnlineStoreConfig <- value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#tags-1">SagemakerFeatureGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: seq<string * string>) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#tags_all-1">SagemakerFeatureGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: seq<string * string>) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        /// <summary>
        /// throughput_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#throughput_config-1">SagemakerFeatureGroup#throughput_config</a>
        /// </summary>
        [<CustomOperation "throughput_config">]
        member _.ThroughputConfig(state: SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>, value: aws.SagemakerFeatureGroup.SagemakerFeatureGroupThroughputConfig) : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.ThroughputConfig <- value)
            state : SagemakerFeatureGroupState<'EventTimeFeatureName, 'FeatureDefinition, 'FeatureGroupName, 'RecordIdentifierFeatureName, 'RoleArn>

        member _.Run(state: SagemakerFeatureGroupState<Present, Present, Present, Present, Present>) : aws.SagemakerFeatureGroup.SagemakerFeatureGroup =
            let config = aws.SagemakerFeatureGroup.SagemakerFeatureGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerFeatureGroup.SagemakerFeatureGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerFeatureGroup: missing required arguments. Must call: event_time_feature_name, feature_definition, feature_group_name, record_identifier_feature_name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerFeatureGroupState<_, _, _, _, _>) : aws.SagemakerFeatureGroup.SagemakerFeatureGroup =
            Unchecked.defaultof<aws.SagemakerFeatureGroup.SagemakerFeatureGroup>

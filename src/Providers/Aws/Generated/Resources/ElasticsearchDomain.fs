namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticsearchDomainState<'DomainName> = { assignments: ResizeArray<aws.ElasticsearchDomain.ElasticsearchDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain">aws_elasticsearch_domain</a>.
    /// </summary>
    type ElasticsearchDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainState<Missing>)

        member _.Zero(()) : ElasticsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#domain_name-1">ElasticsearchDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ElasticsearchDomainState<Missing>, value: string) : ElasticsearchDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ElasticsearchDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#access_policies-1">ElasticsearchDomain#access_policies</a>.
        /// </summary>
        [<CustomOperation "access_policies">]
        member _.AccessPolicies(state: ElasticsearchDomainState<'DomainName>, value: string) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AccessPolicies <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#advanced_options-1">ElasticsearchDomain#advanced_options</a>.
        /// </summary>
        [<CustomOperation "advanced_options">]
        member _.AdvancedOptions(state: ElasticsearchDomainState<'DomainName>, value: seq<string * string>) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdvancedOptions <- dict value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// advanced_security_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#advanced_security_options-1">ElasticsearchDomain#advanced_security_options</a>
        /// </summary>
        [<CustomOperation "advanced_security_options">]
        member _.AdvancedSecurityOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdvancedSecurityOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// auto_tune_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#auto_tune_options-1">ElasticsearchDomain#auto_tune_options</a>
        /// </summary>
        [<CustomOperation "auto_tune_options">]
        member _.AutoTuneOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainAutoTuneOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoTuneOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// cluster_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cluster_config-1">ElasticsearchDomain#cluster_config</a>
        /// </summary>
        [<CustomOperation "cluster_config">]
        member _.ClusterConfig(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainClusterConfig) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.ClusterConfig <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// cognito_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cognito_options-1">ElasticsearchDomain#cognito_options</a>
        /// </summary>
        [<CustomOperation "cognito_options">]
        member _.CognitoOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainCognitoOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.CognitoOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// domain_endpoint_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#domain_endpoint_options-1">ElasticsearchDomain#domain_endpoint_options</a>
        /// </summary>
        [<CustomOperation "domain_endpoint_options">]
        member _.DomainEndpointOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainDomainEndpointOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.DomainEndpointOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// ebs_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#ebs_options-1">ElasticsearchDomain#ebs_options</a>
        /// </summary>
        [<CustomOperation "ebs_options">]
        member _.EbsOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainEbsOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.EbsOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#elasticsearch_version-1">ElasticsearchDomain#elasticsearch_version</a>.
        /// </summary>
        [<CustomOperation "elasticsearch_version">]
        member _.ElasticsearchVersion(state: ElasticsearchDomainState<'DomainName>, value: string) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.ElasticsearchVersion <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// encrypt_at_rest block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#encrypt_at_rest-1">ElasticsearchDomain#encrypt_at_rest</a>
        /// </summary>
        [<CustomOperation "encrypt_at_rest">]
        member _.EncryptAtRest(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainEncryptAtRest) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.EncryptAtRest <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#id-1">ElasticsearchDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticsearchDomainState<'DomainName>, value: string) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// log_publishing_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#log_publishing_options-1">ElasticsearchDomain#log_publishing_options</a> Accepts: aws.IResolvable | aws.ElasticsearchDomain.ElasticsearchDomainLogPublishingOptions[]
        /// </summary>
        [<CustomOperation "log_publishing_options">]
        member _.LogPublishingOptions(state: ElasticsearchDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.LogPublishingOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// node_to_node_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#node_to_node_encryption-1">ElasticsearchDomain#node_to_node_encryption</a>
        /// </summary>
        [<CustomOperation "node_to_node_encryption">]
        member _.NodeToNodeEncryption(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainNodeToNodeEncryption) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.NodeToNodeEncryption <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// snapshot_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#snapshot_options-1">ElasticsearchDomain#snapshot_options</a>
        /// </summary>
        [<CustomOperation "snapshot_options">]
        member _.SnapshotOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainSnapshotOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.SnapshotOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#tags-1">ElasticsearchDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticsearchDomainState<'DomainName>, value: seq<string * string>) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#tags_all-1">ElasticsearchDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticsearchDomainState<'DomainName>, value: seq<string * string>) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#timeouts-1">ElasticsearchDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainTimeouts) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticsearchDomainState<'DomainName>

        /// <summary>
        /// vpc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#vpc_options-1">ElasticsearchDomain#vpc_options</a>
        /// </summary>
        [<CustomOperation "vpc_options">]
        member _.VpcOptions(state: ElasticsearchDomainState<'DomainName>, value: aws.ElasticsearchDomain.ElasticsearchDomainVpcOptions) : ElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.VpcOptions <- value)
            state : ElasticsearchDomainState<'DomainName>

        member _.Run(state: ElasticsearchDomainState<Present>) : aws.ElasticsearchDomain.ElasticsearchDomain =
            let config = aws.ElasticsearchDomain.ElasticsearchDomainConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticsearchDomain.ElasticsearchDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticsearchDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: ElasticsearchDomainState<_>) : aws.ElasticsearchDomain.ElasticsearchDomain =
            Unchecked.defaultof<aws.ElasticsearchDomain.ElasticsearchDomain>

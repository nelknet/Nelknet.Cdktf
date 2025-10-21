namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchDomainState<'DomainName> = { assignments: ResizeArray<aws.OpensearchDomain.OpensearchDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain">aws_opensearch_domain</a>.
    /// </summary>
    type OpensearchDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainState<Missing>)

        member _.Zero(()) : OpensearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_name-1">OpensearchDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: OpensearchDomainState<Missing>, value: string) : OpensearchDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : OpensearchDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#access_policies-1">OpensearchDomain#access_policies</a>.
        /// </summary>
        [<CustomOperation "access_policies">]
        member _.AccessPolicies(state: OpensearchDomainState<'DomainName>, value: string) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AccessPolicies <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_options-1">OpensearchDomain#advanced_options</a>.
        /// </summary>
        [<CustomOperation "advanced_options">]
        member _.AdvancedOptions(state: OpensearchDomainState<'DomainName>, value: seq<string * string>) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdvancedOptions <- dict value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// advanced_security_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#advanced_security_options-1">OpensearchDomain#advanced_security_options</a>
        /// </summary>
        [<CustomOperation "advanced_security_options">]
        member _.AdvancedSecurityOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainAdvancedSecurityOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AdvancedSecurityOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// auto_tune_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#auto_tune_options-1">OpensearchDomain#auto_tune_options</a>
        /// </summary>
        [<CustomOperation "auto_tune_options">]
        member _.AutoTuneOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainAutoTuneOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.AutoTuneOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// cluster_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cluster_config-1">OpensearchDomain#cluster_config</a>
        /// </summary>
        [<CustomOperation "cluster_config">]
        member _.ClusterConfig(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainClusterConfig) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.ClusterConfig <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// cognito_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cognito_options-1">OpensearchDomain#cognito_options</a>
        /// </summary>
        [<CustomOperation "cognito_options">]
        member _.CognitoOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainCognitoOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.CognitoOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// domain_endpoint_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#domain_endpoint_options-1">OpensearchDomain#domain_endpoint_options</a>
        /// </summary>
        [<CustomOperation "domain_endpoint_options">]
        member _.DomainEndpointOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainDomainEndpointOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.DomainEndpointOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// ebs_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ebs_options-1">OpensearchDomain#ebs_options</a>
        /// </summary>
        [<CustomOperation "ebs_options">]
        member _.EbsOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainEbsOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.EbsOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// encrypt_at_rest block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#encrypt_at_rest-1">OpensearchDomain#encrypt_at_rest</a>
        /// </summary>
        [<CustomOperation "encrypt_at_rest">]
        member _.EncryptAtRest(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainEncryptAtRest) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.EncryptAtRest <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#engine_version-1">OpensearchDomain#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: OpensearchDomainState<'DomainName>, value: string) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#id-1">OpensearchDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchDomainState<'DomainName>, value: string) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#ip_address_type-1">OpensearchDomain#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: OpensearchDomainState<'DomainName>, value: string) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// log_publishing_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#log_publishing_options-1">OpensearchDomain#log_publishing_options</a> Accepts: aws.IResolvable | aws.OpensearchDomain.OpensearchDomainLogPublishingOptions[]
        /// </summary>
        [<CustomOperation "log_publishing_options">]
        member _.LogPublishingOptions(state: OpensearchDomainState<'DomainName>, value: HashiCorp.Cdktf.IResolvable) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.LogPublishingOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// node_to_node_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#node_to_node_encryption-1">OpensearchDomain#node_to_node_encryption</a>
        /// </summary>
        [<CustomOperation "node_to_node_encryption">]
        member _.NodeToNodeEncryption(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainNodeToNodeEncryption) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.NodeToNodeEncryption <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// off_peak_window_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window_options-1">OpensearchDomain#off_peak_window_options</a>
        /// </summary>
        [<CustomOperation "off_peak_window_options">]
        member _.OffPeakWindowOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.OffPeakWindowOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// snapshot_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#snapshot_options-1">OpensearchDomain#snapshot_options</a>
        /// </summary>
        [<CustomOperation "snapshot_options">]
        member _.SnapshotOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainSnapshotOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.SnapshotOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// software_update_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#software_update_options-1">OpensearchDomain#software_update_options</a>
        /// </summary>
        [<CustomOperation "software_update_options">]
        member _.SoftwareUpdateOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainSoftwareUpdateOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.SoftwareUpdateOptions <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags-1">OpensearchDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpensearchDomainState<'DomainName>, value: seq<string * string>) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#tags_all-1">OpensearchDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OpensearchDomainState<'DomainName>, value: seq<string * string>) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#timeouts-1">OpensearchDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainTimeouts) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchDomainState<'DomainName>

        /// <summary>
        /// vpc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#vpc_options-1">OpensearchDomain#vpc_options</a>
        /// </summary>
        [<CustomOperation "vpc_options">]
        member _.VpcOptions(state: OpensearchDomainState<'DomainName>, value: aws.OpensearchDomain.OpensearchDomainVpcOptions) : OpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.VpcOptions <- value)
            state : OpensearchDomainState<'DomainName>

        member _.Run(state: OpensearchDomainState<Present>) : aws.OpensearchDomain.OpensearchDomain =
            let config = aws.OpensearchDomain.OpensearchDomainConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchDomain.OpensearchDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: OpensearchDomainState<_>) : aws.OpensearchDomain.OpensearchDomain =
            Unchecked.defaultof<aws.OpensearchDomain.OpensearchDomain>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> = { assignments: ResizeArray<aws.SagemakerDomain.SagemakerDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain">aws_sagemaker_domain</a>.
    /// </summary>
    type SagemakerDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerDomainState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDomainState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerDomainState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDomainState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#auth_mode-1">SagemakerDomain#auth_mode</a>.
        /// </summary>
        [<CustomOperation "auth_mode">]
        member _.AuthMode(state: SagemakerDomainState<Missing, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<Present, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.AuthMode <- value)
            ({ assignments = state.assignments } : SagemakerDomainState<Present, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// default_user_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_user_settings-1">SagemakerDomain#default_user_settings</a>
        /// </summary>
        [<CustomOperation "default_user_settings">]
        member _.DefaultUserSettings(state: SagemakerDomainState<'AuthMode, Missing, 'DomainName, 'SubnetIds, 'VpcId>, value: aws.SagemakerDomain.SagemakerDomainDefaultUserSettings) : SagemakerDomainState<'AuthMode, Present, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.DefaultUserSettings <- value)
            ({ assignments = state.assignments } : SagemakerDomainState<'AuthMode, Present, 'DomainName, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#domain_name-1">SagemakerDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, Missing, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, Present, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, Present, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#subnet_ids-1">SagemakerDomain#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, Missing, 'VpcId>, value: seq<string>) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#vpc_id-1">SagemakerDomain#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, Missing>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_network_access_type-1">SagemakerDomain#app_network_access_type</a>.
        /// </summary>
        [<CustomOperation "app_network_access_type">]
        member _.AppNetworkAccessType(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.AppNetworkAccessType <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_security_group_management-1">SagemakerDomain#app_security_group_management</a>.
        /// </summary>
        [<CustomOperation "app_security_group_management">]
        member _.AppSecurityGroupManagement(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.AppSecurityGroupManagement <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// default_space_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_space_settings-1">SagemakerDomain#default_space_settings</a>
        /// </summary>
        [<CustomOperation "default_space_settings">]
        member _.DefaultSpaceSettings(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: aws.SagemakerDomain.SagemakerDomainDefaultSpaceSettings) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.DefaultSpaceSettings <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// domain_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#domain_settings-1">SagemakerDomain#domain_settings</a>
        /// </summary>
        [<CustomOperation "domain_settings">]
        member _.DomainSettings(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: aws.SagemakerDomain.SagemakerDomainDomainSettings) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.DomainSettings <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#id-1">SagemakerDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#kms_key_id-1">SagemakerDomain#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#retention_policy-1">SagemakerDomain#retention_policy</a>
        /// </summary>
        [<CustomOperation "retention_policy">]
        member _.RetentionPolicy(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: aws.SagemakerDomain.SagemakerDomainRetentionPolicy) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.RetentionPolicy <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#tag_propagation-1">SagemakerDomain#tag_propagation</a>.
        /// </summary>
        [<CustomOperation "tag_propagation">]
        member _.TagPropagation(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: string) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.TagPropagation <- value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#tags-1">SagemakerDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: seq<string * string>) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#tags_all-1">SagemakerDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>, value: seq<string * string>) : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerDomainState<'AuthMode, 'DefaultUserSettings, 'DomainName, 'SubnetIds, 'VpcId>

        member _.Run(state: SagemakerDomainState<Present, Present, Present, Present, Present>) : aws.SagemakerDomain.SagemakerDomain =
            let config = aws.SagemakerDomain.SagemakerDomainConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerDomain.SagemakerDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerDomain: missing required arguments. Must call: auth_mode, default_user_settings, domain_name, subnet_ids, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: SagemakerDomainState<_, _, _, _, _>) : aws.SagemakerDomain.SagemakerDomain =
            Unchecked.defaultof<aws.SagemakerDomain.SagemakerDomain>

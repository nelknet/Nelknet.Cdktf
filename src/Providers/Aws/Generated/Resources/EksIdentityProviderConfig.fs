namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksIdentityProviderConfigState<'ClusterName, 'Oidc> = { assignments: ResizeArray<aws.EksIdentityProviderConfig.EksIdentityProviderConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config">aws_eks_identity_provider_config</a>.
    /// </summary>
    type EksIdentityProviderConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksIdentityProviderConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksIdentityProviderConfigState<Missing, Missing>)

        member _.Zero(()) : EksIdentityProviderConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksIdentityProviderConfigState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#cluster_name-1">EksIdentityProviderConfig#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksIdentityProviderConfigState<Missing, 'Oidc>, value: string) : EksIdentityProviderConfigState<Present, 'Oidc> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksIdentityProviderConfigState<Present, 'Oidc>)

        /// <summary>
        /// oidc block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#oidc-1">EksIdentityProviderConfig#oidc</a>
        /// </summary>
        [<CustomOperation "oidc">]
        member _.Oidc(state: EksIdentityProviderConfigState<'ClusterName, Missing>, value: aws.EksIdentityProviderConfig.EksIdentityProviderConfigOidc) : EksIdentityProviderConfigState<'ClusterName, Present> =
            state.assignments.Add(fun config -> config.Oidc <- value)
            ({ assignments = state.assignments } : EksIdentityProviderConfigState<'ClusterName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#id-1">EksIdentityProviderConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksIdentityProviderConfigState<'ClusterName, 'Oidc>, value: string) : EksIdentityProviderConfigState<'ClusterName, 'Oidc> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksIdentityProviderConfigState<'ClusterName, 'Oidc>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#tags-1">EksIdentityProviderConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksIdentityProviderConfigState<'ClusterName, 'Oidc>, value: seq<string * string>) : EksIdentityProviderConfigState<'ClusterName, 'Oidc> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksIdentityProviderConfigState<'ClusterName, 'Oidc>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#tags_all-1">EksIdentityProviderConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksIdentityProviderConfigState<'ClusterName, 'Oidc>, value: seq<string * string>) : EksIdentityProviderConfigState<'ClusterName, 'Oidc> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksIdentityProviderConfigState<'ClusterName, 'Oidc>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_identity_provider_config#timeouts-1">EksIdentityProviderConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksIdentityProviderConfigState<'ClusterName, 'Oidc>, value: aws.EksIdentityProviderConfig.EksIdentityProviderConfigTimeouts) : EksIdentityProviderConfigState<'ClusterName, 'Oidc> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksIdentityProviderConfigState<'ClusterName, 'Oidc>

        member _.Run(state: EksIdentityProviderConfigState<Present, Present>) : aws.EksIdentityProviderConfig.EksIdentityProviderConfig =
            let config = aws.EksIdentityProviderConfig.EksIdentityProviderConfigConfig()
            for setter in state.assignments do
                setter config
            aws.EksIdentityProviderConfig.EksIdentityProviderConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksIdentityProviderConfig: missing required arguments. Must call: cluster_name, oidc.", 9999, IsError = true)>]
        member _.Run(_: EksIdentityProviderConfigState<_, _>) : aws.EksIdentityProviderConfig.EksIdentityProviderConfig =
            Unchecked.defaultof<aws.EksIdentityProviderConfig.EksIdentityProviderConfig>

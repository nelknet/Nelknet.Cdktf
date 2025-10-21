namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo> = { assignments: ResizeArray<azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule">azurerm_container_registry_cache_rule</a>.
    /// </summary>
    type ContainerRegistryCacheRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryCacheRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryCacheRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryCacheRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryCacheRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#container_registry_id-1">ContainerRegistryCacheRule#container_registry_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_id">]
        member _.ContainerRegistryId(state: ContainerRegistryCacheRuleState<Missing, 'Name, 'SourceRepo, 'TargetRepo>, value: string) : ContainerRegistryCacheRuleState<Present, 'Name, 'SourceRepo, 'TargetRepo> =
            state.assignments.Add(fun config -> config.ContainerRegistryId <- value)
            ({ assignments = state.assignments } : ContainerRegistryCacheRuleState<Present, 'Name, 'SourceRepo, 'TargetRepo>)

        /// <summary>
        /// The name of the cache rule. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#name-1">ContainerRegistryCacheRule#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, Missing, 'SourceRepo, 'TargetRepo>, value: string) : ContainerRegistryCacheRuleState<'ContainerRegistryId, Present, 'SourceRepo, 'TargetRepo> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryCacheRuleState<'ContainerRegistryId, Present, 'SourceRepo, 'TargetRepo>)

        /// <summary>
        /// The full source repository path such as 'docker.io/library/ubuntu'. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#source_repo-1">ContainerRegistryCacheRule#source_repo</a>
        /// </summary>
        [<CustomOperation "source_repo">]
        member _.SourceRepo(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, Missing, 'TargetRepo>, value: string) : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, Present, 'TargetRepo> =
            state.assignments.Add(fun config -> config.SourceRepo <- value)
            ({ assignments = state.assignments } : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, Present, 'TargetRepo>)

        /// <summary>
        /// The target repository namespace such as 'ubuntu'. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#target_repo-1">ContainerRegistryCacheRule#target_repo</a>
        /// </summary>
        [<CustomOperation "target_repo">]
        member _.TargetRepo(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, Missing>, value: string) : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, Present> =
            state.assignments.Add(fun config -> config.TargetRepo <- value)
            ({ assignments = state.assignments } : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, Present>)

        /// <summary>
        /// The ARM resource ID of the credential store which is associated with the cache rule. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#credential_set_id-1">ContainerRegistryCacheRule#credential_set_id</a>
        /// </summary>
        [<CustomOperation "credential_set_id">]
        member _.CredentialSetId(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>, value: string) : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo> =
            state.assignments.Add(fun config -> config.CredentialSetId <- value)
            state : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#id-1">ContainerRegistryCacheRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>, value: string) : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_cache_rule#timeouts-1">ContainerRegistryCacheRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>, value: azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRuleTimeouts) : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name, 'SourceRepo, 'TargetRepo>

        member _.Run(state: ContainerRegistryCacheRuleState<Present, Present, Present, Present>) : azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRule =
            let config = azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryCacheRule: missing required arguments. Must call: container_registry_id, name, source_repo, target_repo.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryCacheRuleState<_, _, _, _>) : azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRule =
            Unchecked.defaultof<azurerm.ContainerRegistryCacheRule.ContainerRegistryCacheRule>

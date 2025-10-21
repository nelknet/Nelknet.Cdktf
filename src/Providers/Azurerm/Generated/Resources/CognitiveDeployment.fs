namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku> = { assignments: ResizeArray<azurerm.CognitiveDeployment.CognitiveDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment">azurerm_cognitive_deployment</a>.
    /// </summary>
    type CognitiveDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitiveDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveDeploymentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CognitiveDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveDeploymentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#cognitive_account_id-1">CognitiveDeployment#cognitive_account_id</a>.
        /// </summary>
        [<CustomOperation "cognitive_account_id">]
        member _.CognitiveAccountId(state: CognitiveDeploymentState<Missing, 'Model, 'Name, 'Sku>, value: string) : CognitiveDeploymentState<Present, 'Model, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.CognitiveAccountId <- value)
            ({ assignments = state.assignments } : CognitiveDeploymentState<Present, 'Model, 'Name, 'Sku>)

        /// <summary>
        /// model block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#model-1">CognitiveDeployment#model</a>
        /// </summary>
        [<CustomOperation "model">]
        member _.Model(state: CognitiveDeploymentState<'CognitiveAccountId, Missing, 'Name, 'Sku>, value: azurerm.CognitiveDeployment.CognitiveDeploymentModel) : CognitiveDeploymentState<'CognitiveAccountId, Present, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Model <- value)
            ({ assignments = state.assignments } : CognitiveDeploymentState<'CognitiveAccountId, Present, 'Name, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#name-1">CognitiveDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, Missing, 'Sku>, value: string) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, Present, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitiveDeploymentState<'CognitiveAccountId, 'Model, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#sku-1">CognitiveDeployment#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, Missing>, value: azurerm.CognitiveDeployment.CognitiveDeploymentSku) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#id-1">CognitiveDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>, value: string) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#rai_policy_name-1">CognitiveDeployment#rai_policy_name</a>.
        /// </summary>
        [<CustomOperation "rai_policy_name">]
        member _.RaiPolicyName(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>, value: string) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.RaiPolicyName <- value)
            state : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#timeouts-1">CognitiveDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>, value: azurerm.CognitiveDeployment.CognitiveDeploymentTimeouts) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#version_upgrade_option-1">CognitiveDeployment#version_upgrade_option</a>.
        /// </summary>
        [<CustomOperation "version_upgrade_option">]
        member _.VersionUpgradeOption(state: CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>, value: string) : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.VersionUpgradeOption <- value)
            state : CognitiveDeploymentState<'CognitiveAccountId, 'Model, 'Name, 'Sku>

        member _.Run(state: CognitiveDeploymentState<Present, Present, Present, Present>) : azurerm.CognitiveDeployment.CognitiveDeployment =
            let config = azurerm.CognitiveDeployment.CognitiveDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.CognitiveDeployment.CognitiveDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cognitiveDeployment: missing required arguments. Must call: cognitive_account_id, model, name, sku.", 9999, IsError = true)>]
        member _.Run(_: CognitiveDeploymentState<_, _, _, _>) : azurerm.CognitiveDeployment.CognitiveDeployment =
            Unchecked.defaultof<azurerm.CognitiveDeployment.CognitiveDeployment>

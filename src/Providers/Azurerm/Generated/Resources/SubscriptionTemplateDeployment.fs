namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionTemplateDeploymentState<'Location, 'Name> = { assignments: ResizeArray<azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment">azurerm_subscription_template_deployment</a>.
    /// </summary>
    type SubscriptionTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionTemplateDeploymentState<Missing, Missing>)

        member _.Zero(()) : SubscriptionTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionTemplateDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#location-1">SubscriptionTemplateDeployment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SubscriptionTemplateDeploymentState<Missing, 'Name>, value: string) : SubscriptionTemplateDeploymentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SubscriptionTemplateDeploymentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#name-1">SubscriptionTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionTemplateDeploymentState<'Location, Missing>, value: string) : SubscriptionTemplateDeploymentState<'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionTemplateDeploymentState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#debug_level-1">SubscriptionTemplateDeployment#debug_level</a>.
        /// </summary>
        [<CustomOperation "debug_level">]
        member _.DebugLevel(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: string) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.DebugLevel <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#id-1">SubscriptionTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: string) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#parameters_content-1">SubscriptionTemplateDeployment#parameters_content</a>.
        /// </summary>
        [<CustomOperation "parameters_content">]
        member _.ParametersContent(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: string) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.ParametersContent <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#tags-1">SubscriptionTemplateDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: seq<string * string>) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#template_content-1">SubscriptionTemplateDeployment#template_content</a>.
        /// </summary>
        [<CustomOperation "template_content">]
        member _.TemplateContent(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: string) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.TemplateContent <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#template_spec_version_id-1">SubscriptionTemplateDeployment#template_spec_version_id</a>.
        /// </summary>
        [<CustomOperation "template_spec_version_id">]
        member _.TemplateSpecVersionId(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: string) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.TemplateSpecVersionId <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_template_deployment#timeouts-1">SubscriptionTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionTemplateDeploymentState<'Location, 'Name>, value: azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeploymentTimeouts) : SubscriptionTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionTemplateDeploymentState<'Location, 'Name>

        member _.Run(state: SubscriptionTemplateDeploymentState<Present, Present>) : azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeployment =
            let config = azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionTemplateDeployment: missing required arguments. Must call: location, name.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionTemplateDeploymentState<_, _>) : azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeployment =
            Unchecked.defaultof<azurerm.SubscriptionTemplateDeployment.SubscriptionTemplateDeployment>

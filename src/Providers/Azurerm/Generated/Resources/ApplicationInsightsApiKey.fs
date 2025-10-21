namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name> = { assignments: ResizeArray<azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key">azurerm_application_insights_api_key</a>.
    /// </summary>
    type ApplicationInsightsApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsApiKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsApiKeyState<Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsApiKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsApiKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#application_insights_id-1">ApplicationInsightsApiKey#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: ApplicationInsightsApiKeyState<Missing, 'Name>, value: string) : ApplicationInsightsApiKeyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : ApplicationInsightsApiKeyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#name-1">ApplicationInsightsApiKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsApiKeyState<'ApplicationInsightsId, Missing>, value: string) : ApplicationInsightsApiKeyState<'ApplicationInsightsId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsApiKeyState<'ApplicationInsightsId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#id-1">ApplicationInsightsApiKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>, value: string) : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#read_permissions-1">ApplicationInsightsApiKey#read_permissions</a>.
        /// </summary>
        [<CustomOperation "read_permissions">]
        member _.ReadPermissions(state: ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>, value: seq<string>) : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.ReadPermissions <- (value |> Seq.toArray))
            state : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#timeouts-1">ApplicationInsightsApiKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>, value: azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKeyTimeouts) : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_api_key#write_permissions-1">ApplicationInsightsApiKey#write_permissions</a>.
        /// </summary>
        [<CustomOperation "write_permissions">]
        member _.WritePermissions(state: ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>, value: seq<string>) : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name> =
            state.assignments.Add(fun config -> config.WritePermissions <- (value |> Seq.toArray))
            state : ApplicationInsightsApiKeyState<'ApplicationInsightsId, 'Name>

        member _.Run(state: ApplicationInsightsApiKeyState<Present, Present>) : azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKey =
            let config = azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsApiKey: missing required arguments. Must call: application_insights_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsApiKeyState<_, _>) : azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKey =
            Unchecked.defaultof<azurerm.ApplicationInsightsApiKey.ApplicationInsightsApiKey>

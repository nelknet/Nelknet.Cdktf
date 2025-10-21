namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test">azurerm_application_insights_web_test</a>.
    /// </summary>
    type ApplicationInsightsWebTestBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsWebTestState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWebTestState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsWebTestState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWebTestState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#application_insights_id-1">ApplicationInsightsWebTest#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: ApplicationInsightsWebTestState<Missing, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<Present, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<Present, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#configuration-1">ApplicationInsightsWebTest#configuration</a>.
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, Missing, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, Present, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, Present, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#geo_locations-1">ApplicationInsightsWebTest#geo_locations</a>.
        /// </summary>
        [<CustomOperation "geo_locations">]
        member _.GeoLocations(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, Missing, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, Present, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoLocations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, Present, 'Kind, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#kind-1">ApplicationInsightsWebTest#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#location-1">ApplicationInsightsWebTest#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, Missing, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#name-1">ApplicationInsightsWebTest#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, Missing, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#resource_group_name-1">ApplicationInsightsWebTest#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, Missing>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#description-1">ApplicationInsightsWebTest#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#enabled-1">ApplicationInsightsWebTest#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#enabled-1">ApplicationInsightsWebTest#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#frequency-1">ApplicationInsightsWebTest#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: double) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#id-1">ApplicationInsightsWebTest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#retry_enabled-1">ApplicationInsightsWebTest#retry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "retry_enabled">]
        member _.RetryEnabled(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetryEnabled <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#retry_enabled-1">ApplicationInsightsWebTest#retry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "retry_enabled">]
        member _.RetryEnabled(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetryEnabled <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#tags-1">ApplicationInsightsWebTest#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#timeout-1">ApplicationInsightsWebTest#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: double) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_web_test#timeouts-1">ApplicationInsightsWebTest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTestTimeouts) : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsWebTestState<'ApplicationInsightsId, 'Configuration, 'GeoLocations, 'Kind, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ApplicationInsightsWebTestState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTest =
            let config = azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTestConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsWebTest: missing required arguments. Must call: application_insights_id, configuration, geo_locations, kind, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsWebTestState<_, _, _, _, _, _, _>) : azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTest =
            Unchecked.defaultof<azurerm.ApplicationInsightsWebTest.ApplicationInsightsWebTest>

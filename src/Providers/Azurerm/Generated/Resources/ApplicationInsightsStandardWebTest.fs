namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test">azurerm_application_insights_standard_web_test</a>.
    /// </summary>
    type ApplicationInsightsStandardWebTestBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsStandardWebTestState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsStandardWebTestState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsStandardWebTestState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsStandardWebTestState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#application_insights_id-1">ApplicationInsightsStandardWebTest#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: ApplicationInsightsStandardWebTestState<Missing, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: string) : ApplicationInsightsStandardWebTestState<Present, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<Present, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#geo_locations-1">ApplicationInsightsStandardWebTest#geo_locations</a>.
        /// </summary>
        [<CustomOperation "geo_locations">]
        member _.GeoLocations(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, Missing, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: seq<string>) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, Present, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoLocations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, Present, 'Location, 'Name, 'Request, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#location-1">ApplicationInsightsStandardWebTest#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, Missing, 'Name, 'Request, 'ResourceGroupName>, value: string) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, Present, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, Present, 'Name, 'Request, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#name-1">ApplicationInsightsStandardWebTest#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, Missing, 'Request, 'ResourceGroupName>, value: string) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, Present, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, Present, 'Request, 'ResourceGroupName>)

        /// <summary>
        /// request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#request-1">ApplicationInsightsStandardWebTest#request</a>
        /// </summary>
        [<CustomOperation "request">]
        member _.Request(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, Missing, 'ResourceGroupName>, value: azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestRequest) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Request <- value)
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#resource_group_name-1">ApplicationInsightsStandardWebTest#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, Missing>, value: string) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#description-1">ApplicationInsightsStandardWebTest#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: string) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#enabled-1">ApplicationInsightsStandardWebTest#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: bool) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#enabled-1">ApplicationInsightsStandardWebTest#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#frequency-1">ApplicationInsightsStandardWebTest#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: double) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#id-1">ApplicationInsightsStandardWebTest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: string) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#retry_enabled-1">ApplicationInsightsStandardWebTest#retry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "retry_enabled">]
        member _.RetryEnabled(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: bool) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetryEnabled <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#retry_enabled-1">ApplicationInsightsStandardWebTest#retry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "retry_enabled">]
        member _.RetryEnabled(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetryEnabled <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#tags-1">ApplicationInsightsStandardWebTest#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: seq<string * string>) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#timeout-1">ApplicationInsightsStandardWebTest#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: double) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#timeouts-1">ApplicationInsightsStandardWebTest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestTimeouts) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        /// <summary>
        /// validation_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#validation_rules-1">ApplicationInsightsStandardWebTest#validation_rules</a>
        /// </summary>
        [<CustomOperation "validation_rules">]
        member _.ValidationRules(state: ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>, value: azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRules) : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ValidationRules <- value)
            state : ApplicationInsightsStandardWebTestState<'ApplicationInsightsId, 'GeoLocations, 'Location, 'Name, 'Request, 'ResourceGroupName>

        member _.Run(state: ApplicationInsightsStandardWebTestState<Present, Present, Present, Present, Present, Present>) : azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTest =
            let config = azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsStandardWebTest: missing required arguments. Must call: application_insights_id, geo_locations, location, name, request, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsStandardWebTestState<_, _, _, _, _, _>) : azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTest =
            Unchecked.defaultof<azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTest>

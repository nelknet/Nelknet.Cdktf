namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogServiceActionState<'Definition, 'Name> = { assignments: ResizeArray<aws.ServicecatalogServiceAction.ServicecatalogServiceActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action">aws_servicecatalog_service_action</a>.
    /// </summary>
    type ServicecatalogServiceActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogServiceActionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogServiceActionState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogServiceActionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogServiceActionState<Missing, Missing>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#definition-1">ServicecatalogServiceAction#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: ServicecatalogServiceActionState<Missing, 'Name>, value: aws.ServicecatalogServiceAction.ServicecatalogServiceActionDefinition) : ServicecatalogServiceActionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : ServicecatalogServiceActionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#name-1">ServicecatalogServiceAction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogServiceActionState<'Definition, Missing>, value: string) : ServicecatalogServiceActionState<'Definition, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogServiceActionState<'Definition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#accept_language-1">ServicecatalogServiceAction#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogServiceActionState<'Definition, 'Name>, value: string) : ServicecatalogServiceActionState<'Definition, 'Name> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogServiceActionState<'Definition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#description-1">ServicecatalogServiceAction#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogServiceActionState<'Definition, 'Name>, value: string) : ServicecatalogServiceActionState<'Definition, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogServiceActionState<'Definition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#id-1">ServicecatalogServiceAction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogServiceActionState<'Definition, 'Name>, value: string) : ServicecatalogServiceActionState<'Definition, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogServiceActionState<'Definition, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_service_action#timeouts-1">ServicecatalogServiceAction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogServiceActionState<'Definition, 'Name>, value: aws.ServicecatalogServiceAction.ServicecatalogServiceActionTimeouts) : ServicecatalogServiceActionState<'Definition, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogServiceActionState<'Definition, 'Name>

        member _.Run(state: ServicecatalogServiceActionState<Present, Present>) : aws.ServicecatalogServiceAction.ServicecatalogServiceAction =
            let config = aws.ServicecatalogServiceAction.ServicecatalogServiceActionConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogServiceAction.ServicecatalogServiceAction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogServiceAction: missing required arguments. Must call: definition, name.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogServiceActionState<_, _>) : aws.ServicecatalogServiceAction.ServicecatalogServiceAction =
            Unchecked.defaultof<aws.ServicecatalogServiceAction.ServicecatalogServiceAction>

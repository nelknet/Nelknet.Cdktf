namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogappregistryApplicationState<'Name> = { assignments: ResizeArray<aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_application">aws_servicecatalogappregistry_application</a>.
    /// </summary>
    type ServicecatalogappregistryApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogappregistryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryApplicationState<Missing>)

        member _.Zero(()) : ServicecatalogappregistryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogappregistryApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_application#name-1">ServicecatalogappregistryApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogappregistryApplicationState<Missing>, value: string) : ServicecatalogappregistryApplicationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogappregistryApplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_application#description-1">ServicecatalogappregistryApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogappregistryApplicationState<'Name>, value: string) : ServicecatalogappregistryApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogappregistryApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalogappregistry_application#tags-1">ServicecatalogappregistryApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicecatalogappregistryApplicationState<'Name>, value: seq<string * string>) : ServicecatalogappregistryApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicecatalogappregistryApplicationState<'Name>

        member _.Run(state: ServicecatalogappregistryApplicationState<Present>) : aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplication =
            let config = aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogappregistryApplication: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogappregistryApplicationState<_>) : aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplication =
            Unchecked.defaultof<aws.ServicecatalogappregistryApplication.ServicecatalogappregistryApplication>

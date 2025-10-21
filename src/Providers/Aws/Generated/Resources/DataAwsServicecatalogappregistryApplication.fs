namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogappregistryApplicationState<'Id> = { assignments: ResizeArray<aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_application">aws_servicecatalogappregistry_application</a>.
    /// </summary>
    type DataAwsServicecatalogappregistryApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogappregistryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogappregistryApplicationState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogappregistryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogappregistryApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalogappregistry_application#id-1">DataAwsServicecatalogappregistryApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogappregistryApplicationState<Missing>, value: string) : DataAwsServicecatalogappregistryApplicationState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogappregistryApplicationState<Present>)

        member _.Run(state: DataAwsServicecatalogappregistryApplicationState<Present>) : aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplication =
            let config = aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogappregistryApplication: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogappregistryApplicationState<_>) : aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplication =
            Unchecked.defaultof<aws.DataAwsServicecatalogappregistryApplication.DataAwsServicecatalogappregistryApplication>

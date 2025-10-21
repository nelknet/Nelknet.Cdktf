namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminApplicationProvidersState = { assignments: ResizeArray<aws.DataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_providers">aws_ssoadmin_application_providers</a>.
    /// </summary>
    type DataAwsSsoadminApplicationProvidersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminApplicationProvidersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSsoadminApplicationProvidersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// application_providers block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_providers#application_providers-1">DataAwsSsoadminApplicationProviders#application_providers</a> Accepts: aws.IResolvable | aws.DataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProviders[]
        /// </summary>
        [<CustomOperation "application_providers">]
        member _.ApplicationProviders(state: DataAwsSsoadminApplicationProvidersState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsoadminApplicationProvidersState =
            state.assignments.Add(fun config -> config.ApplicationProviders <- value)
            state : DataAwsSsoadminApplicationProvidersState

        member _.Run(state: DataAwsSsoadminApplicationProvidersState) : aws.DataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProviders =
            let config = aws.DataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProviders(StackContext.get (), logicalId, config)

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminApplicationState<'ApplicationArn> = { assignments: ResizeArray<aws.DataAwsSsoadminApplication.DataAwsSsoadminApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application">aws_ssoadmin_application</a>.
    /// </summary>
    type DataAwsSsoadminApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminApplicationState<Missing>)

        member _.Zero(()) : DataAwsSsoadminApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application#application_arn-1">DataAwsSsoadminApplication#application_arn</a>.
        /// </summary>
        [<CustomOperation "application_arn">]
        member _.ApplicationArn(state: DataAwsSsoadminApplicationState<Missing>, value: string) : DataAwsSsoadminApplicationState<Present> =
            state.assignments.Add(fun config -> config.ApplicationArn <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminApplicationState<Present>)

        /// <summary>
        /// portal_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application#portal_options-1">DataAwsSsoadminApplication#portal_options</a> Accepts: aws.IResolvable | aws.DataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptions[]
        /// </summary>
        [<CustomOperation "portal_options">]
        member _.PortalOptions(state: DataAwsSsoadminApplicationState<'ApplicationArn>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsoadminApplicationState<'ApplicationArn> =
            state.assignments.Add(fun config -> config.PortalOptions <- value)
            state : DataAwsSsoadminApplicationState<'ApplicationArn>

        member _.Run(state: DataAwsSsoadminApplicationState<Present>) : aws.DataAwsSsoadminApplication.DataAwsSsoadminApplication =
            let config = aws.DataAwsSsoadminApplication.DataAwsSsoadminApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminApplication.DataAwsSsoadminApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsoadminApplication: missing required arguments. Must call: application_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsoadminApplicationState<_>) : aws.DataAwsSsoadminApplication.DataAwsSsoadminApplication =
            Unchecked.defaultof<aws.DataAwsSsoadminApplication.DataAwsSsoadminApplication>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigEnvironmentState<'ApplicationId, 'Name> = { assignments: ResizeArray<aws.AppconfigEnvironment.AppconfigEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment">aws_appconfig_environment</a>.
    /// </summary>
    type AppconfigEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigEnvironmentState<Missing, Missing>)

        member _.Zero(()) : AppconfigEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigEnvironmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#application_id-1">AppconfigEnvironment#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: AppconfigEnvironmentState<Missing, 'Name>, value: string) : AppconfigEnvironmentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : AppconfigEnvironmentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#name-1">AppconfigEnvironment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppconfigEnvironmentState<'ApplicationId, Missing>, value: string) : AppconfigEnvironmentState<'ApplicationId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppconfigEnvironmentState<'ApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#description-1">AppconfigEnvironment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigEnvironmentState<'ApplicationId, 'Name>, value: string) : AppconfigEnvironmentState<'ApplicationId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigEnvironmentState<'ApplicationId, 'Name>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#monitor-1">AppconfigEnvironment#monitor</a> Accepts: aws.IResolvable | aws.AppconfigEnvironment.AppconfigEnvironmentMonitor[]
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: AppconfigEnvironmentState<'ApplicationId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppconfigEnvironmentState<'ApplicationId, 'Name> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : AppconfigEnvironmentState<'ApplicationId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_environment#tags-1">AppconfigEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigEnvironmentState<'ApplicationId, 'Name>, value: seq<string * string>) : AppconfigEnvironmentState<'ApplicationId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigEnvironmentState<'ApplicationId, 'Name>

        member _.Run(state: AppconfigEnvironmentState<Present, Present>) : aws.AppconfigEnvironment.AppconfigEnvironment =
            let config = aws.AppconfigEnvironment.AppconfigEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigEnvironment.AppconfigEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigEnvironment: missing required arguments. Must call: application_id, name.", 9999, IsError = true)>]
        member _.Run(_: AppconfigEnvironmentState<_, _>) : aws.AppconfigEnvironment.AppconfigEnvironment =
            Unchecked.defaultof<aws.AppconfigEnvironment.AppconfigEnvironment>

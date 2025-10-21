namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName> = { assignments: ResizeArray<aws.AmplifyBackendEnvironment.AmplifyBackendEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment">aws_amplify_backend_environment</a>.
    /// </summary>
    type AmplifyBackendEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmplifyBackendEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyBackendEnvironmentState<Missing, Missing>)

        member _.Zero(()) : AmplifyBackendEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyBackendEnvironmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment#app_id-1">AmplifyBackendEnvironment#app_id</a>.
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: AmplifyBackendEnvironmentState<Missing, 'EnvironmentName>, value: string) : AmplifyBackendEnvironmentState<Present, 'EnvironmentName> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : AmplifyBackendEnvironmentState<Present, 'EnvironmentName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment#environment_name-1">AmplifyBackendEnvironment#environment_name</a>.
        /// </summary>
        [<CustomOperation "environment_name">]
        member _.EnvironmentName(state: AmplifyBackendEnvironmentState<'AppId, Missing>, value: string) : AmplifyBackendEnvironmentState<'AppId, Present> =
            state.assignments.Add(fun config -> config.EnvironmentName <- value)
            ({ assignments = state.assignments } : AmplifyBackendEnvironmentState<'AppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment#deployment_artifacts-1">AmplifyBackendEnvironment#deployment_artifacts</a>.
        /// </summary>
        [<CustomOperation "deployment_artifacts">]
        member _.DeploymentArtifacts(state: AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>, value: string) : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName> =
            state.assignments.Add(fun config -> config.DeploymentArtifacts <- value)
            state : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment#id-1">AmplifyBackendEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>, value: string) : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_backend_environment#stack_name-1">AmplifyBackendEnvironment#stack_name</a>.
        /// </summary>
        [<CustomOperation "stack_name">]
        member _.StackName(state: AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>, value: string) : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName> =
            state.assignments.Add(fun config -> config.StackName <- value)
            state : AmplifyBackendEnvironmentState<'AppId, 'EnvironmentName>

        member _.Run(state: AmplifyBackendEnvironmentState<Present, Present>) : aws.AmplifyBackendEnvironment.AmplifyBackendEnvironment =
            let config = aws.AmplifyBackendEnvironment.AmplifyBackendEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.AmplifyBackendEnvironment.AmplifyBackendEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amplifyBackendEnvironment: missing required arguments. Must call: app_id, environment_name.", 9999, IsError = true)>]
        member _.Run(_: AmplifyBackendEnvironmentState<_, _>) : aws.AmplifyBackendEnvironment.AmplifyBackendEnvironment =
            Unchecked.defaultof<aws.AmplifyBackendEnvironment.AmplifyBackendEnvironment>

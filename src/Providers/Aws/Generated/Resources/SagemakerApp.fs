namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerAppState<'AppName, 'AppType, 'DomainId> = { assignments: ResizeArray<aws.SagemakerApp.SagemakerAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app">aws_sagemaker_app</a>.
    /// </summary>
    type SagemakerAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerAppState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerAppState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#app_name-1">SagemakerApp#app_name</a>.
        /// </summary>
        [<CustomOperation "app_name">]
        member _.AppName(state: SagemakerAppState<Missing, 'AppType, 'DomainId>, value: string) : SagemakerAppState<Present, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.AppName <- value)
            ({ assignments = state.assignments } : SagemakerAppState<Present, 'AppType, 'DomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#app_type-1">SagemakerApp#app_type</a>.
        /// </summary>
        [<CustomOperation "app_type">]
        member _.AppType(state: SagemakerAppState<'AppName, Missing, 'DomainId>, value: string) : SagemakerAppState<'AppName, Present, 'DomainId> =
            state.assignments.Add(fun config -> config.AppType <- value)
            ({ assignments = state.assignments } : SagemakerAppState<'AppName, Present, 'DomainId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#domain_id-1">SagemakerApp#domain_id</a>.
        /// </summary>
        [<CustomOperation "domain_id">]
        member _.DomainId(state: SagemakerAppState<'AppName, 'AppType, Missing>, value: string) : SagemakerAppState<'AppName, 'AppType, Present> =
            state.assignments.Add(fun config -> config.DomainId <- value)
            ({ assignments = state.assignments } : SagemakerAppState<'AppName, 'AppType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#id-1">SagemakerApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: string) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        /// <summary>
        /// resource_spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#resource_spec-1">SagemakerApp#resource_spec</a>
        /// </summary>
        [<CustomOperation "resource_spec">]
        member _.ResourceSpec(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: aws.SagemakerApp.SagemakerAppResourceSpec) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.ResourceSpec <- value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#space_name-1">SagemakerApp#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: string) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#tags-1">SagemakerApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: seq<string * string>) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#tags_all-1">SagemakerApp#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: seq<string * string>) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app#user_profile_name-1">SagemakerApp#user_profile_name</a>.
        /// </summary>
        [<CustomOperation "user_profile_name">]
        member _.UserProfileName(state: SagemakerAppState<'AppName, 'AppType, 'DomainId>, value: string) : SagemakerAppState<'AppName, 'AppType, 'DomainId> =
            state.assignments.Add(fun config -> config.UserProfileName <- value)
            state : SagemakerAppState<'AppName, 'AppType, 'DomainId>

        member _.Run(state: SagemakerAppState<Present, Present, Present>) : aws.SagemakerApp.SagemakerApp =
            let config = aws.SagemakerApp.SagemakerAppConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerApp.SagemakerApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerApp: missing required arguments. Must call: app_name, app_type, domain_id.", 9999, IsError = true)>]
        member _.Run(_: SagemakerAppState<_, _, _>) : aws.SagemakerApp.SagemakerApp =
            Unchecked.defaultof<aws.SagemakerApp.SagemakerApp>

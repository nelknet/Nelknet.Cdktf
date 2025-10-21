namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> = { assignments: ResizeArray<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment">aws_codecatalyst_dev_environment</a>.
    /// </summary>
    type CodecatalystDevEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecatalystDevEnvironmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystDevEnvironmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodecatalystDevEnvironmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystDevEnvironmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// ides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#ides-1">CodecatalystDevEnvironment#ides</a>
        /// </summary>
        [<CustomOperation "ides">]
        member _.Ides(state: CodecatalystDevEnvironmentState<Missing, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentIdes) : CodecatalystDevEnvironmentState<Present, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Ides <- value)
            ({ assignments = state.assignments } : CodecatalystDevEnvironmentState<Present, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#instance_type-1">CodecatalystDevEnvironment#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: CodecatalystDevEnvironmentState<'Ides, Missing, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: string) : CodecatalystDevEnvironmentState<'Ides, Present, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : CodecatalystDevEnvironmentState<'Ides, Present, 'PersistentStorage, 'ProjectName, 'SpaceName>)

        /// <summary>
        /// persistent_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#persistent_storage-1">CodecatalystDevEnvironment#persistent_storage</a>
        /// </summary>
        [<CustomOperation "persistent_storage">]
        member _.PersistentStorage(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, Missing, 'ProjectName, 'SpaceName>, value: aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, Present, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.PersistentStorage <- value)
            ({ assignments = state.assignments } : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, Present, 'ProjectName, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#project_name-1">CodecatalystDevEnvironment#project_name</a>.
        /// </summary>
        [<CustomOperation "project_name">]
        member _.ProjectName(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, Missing, 'SpaceName>, value: string) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, Present, 'SpaceName> =
            state.assignments.Add(fun config -> config.ProjectName <- value)
            ({ assignments = state.assignments } : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, Present, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#space_name-1">CodecatalystDevEnvironment#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, Missing>, value: string) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, Present> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            ({ assignments = state.assignments } : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#alias-1">CodecatalystDevEnvironment#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: string) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#id-1">CodecatalystDevEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: string) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#inactivity_timeout_minutes-1">CodecatalystDevEnvironment#inactivity_timeout_minutes</a>.
        /// </summary>
        [<CustomOperation "inactivity_timeout_minutes">]
        member _.InactivityTimeoutMinutes(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: double) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.InactivityTimeoutMinutes <- value)
            state : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>

        /// <summary>
        /// repositories block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#repositories-1">CodecatalystDevEnvironment#repositories</a> Accepts: aws.IResolvable | aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentRepositories[]
        /// </summary>
        [<CustomOperation "repositories">]
        member _.Repositories(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: HashiCorp.Cdktf.IResolvable) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Repositories <- value)
            state : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#timeouts-1">CodecatalystDevEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>, value: aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentTimeouts) : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodecatalystDevEnvironmentState<'Ides, 'InstanceType, 'PersistentStorage, 'ProjectName, 'SpaceName>

        member _.Run(state: CodecatalystDevEnvironmentState<Present, Present, Present, Present, Present>) : aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment =
            let config = aws.CodecatalystDevEnvironment.CodecatalystDevEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecatalystDevEnvironment: missing required arguments. Must call: ides, instance_type, persistent_storage, project_name, space_name.", 9999, IsError = true)>]
        member _.Run(_: CodecatalystDevEnvironmentState<_, _, _, _, _>) : aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment =
            Unchecked.defaultof<aws.CodecatalystDevEnvironment.CodecatalystDevEnvironment>

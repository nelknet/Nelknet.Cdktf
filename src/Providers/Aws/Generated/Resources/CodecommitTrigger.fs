namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecommitTriggerState<'RepositoryName, 'Trigger> = { assignments: ResizeArray<aws.CodecommitTrigger.CodecommitTriggerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_trigger">aws_codecommit_trigger</a>.
    /// </summary>
    type CodecommitTriggerBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecommitTriggerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitTriggerState<Missing, Missing>)

        member _.Zero(()) : CodecommitTriggerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecommitTriggerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_trigger#repository_name-1">CodecommitTrigger#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: CodecommitTriggerState<Missing, 'Trigger>, value: string) : CodecommitTriggerState<Present, 'Trigger> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : CodecommitTriggerState<Present, 'Trigger>)

        /// <summary>
        /// trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_trigger#trigger-1">CodecommitTrigger#trigger</a> Accepts: aws.IResolvable | aws.CodecommitTrigger.CodecommitTriggerTrigger[]
        /// </summary>
        [<CustomOperation "trigger">]
        member _.Trigger(state: CodecommitTriggerState<'RepositoryName, Missing>, value: HashiCorp.Cdktf.IResolvable) : CodecommitTriggerState<'RepositoryName, Present> =
            state.assignments.Add(fun config -> config.Trigger <- value)
            ({ assignments = state.assignments } : CodecommitTriggerState<'RepositoryName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_trigger#id-1">CodecommitTrigger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecommitTriggerState<'RepositoryName, 'Trigger>, value: string) : CodecommitTriggerState<'RepositoryName, 'Trigger> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecommitTriggerState<'RepositoryName, 'Trigger>

        member _.Run(state: CodecommitTriggerState<Present, Present>) : aws.CodecommitTrigger.CodecommitTrigger =
            let config = aws.CodecommitTrigger.CodecommitTriggerConfig()
            for setter in state.assignments do
                setter config
            aws.CodecommitTrigger.CodecommitTrigger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecommitTrigger: missing required arguments. Must call: repository_name, trigger.", 9999, IsError = true)>]
        member _.Run(_: CodecommitTriggerState<_, _>) : aws.CodecommitTrigger.CodecommitTrigger =
            Unchecked.defaultof<aws.CodecommitTrigger.CodecommitTrigger>

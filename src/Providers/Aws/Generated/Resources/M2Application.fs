namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type M2ApplicationState<'EngineType, 'Name> = { assignments: ResizeArray<aws.M2Application.M2ApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application">aws_m2_application</a>.
    /// </summary>
    type M2ApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : M2ApplicationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : M2ApplicationState<Missing, Missing>)

        member _.Zero(()) : M2ApplicationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : M2ApplicationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#engine_type-1">M2Application#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: M2ApplicationState<Missing, 'Name>, value: string) : M2ApplicationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EngineType <- value)
            ({ assignments = state.assignments } : M2ApplicationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#name-1">M2Application#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: M2ApplicationState<'EngineType, Missing>, value: string) : M2ApplicationState<'EngineType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : M2ApplicationState<'EngineType, Present>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#definition-1">M2Application#definition</a> Accepts: aws.IResolvable | aws.M2Application.M2ApplicationDefinition[]
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: M2ApplicationState<'EngineType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : M2ApplicationState<'EngineType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#description-1">M2Application#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: M2ApplicationState<'EngineType, 'Name>, value: string) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : M2ApplicationState<'EngineType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#kms_key_id-1">M2Application#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: M2ApplicationState<'EngineType, 'Name>, value: string) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : M2ApplicationState<'EngineType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#role_arn-1">M2Application#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: M2ApplicationState<'EngineType, 'Name>, value: string) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : M2ApplicationState<'EngineType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#tags-1">M2Application#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: M2ApplicationState<'EngineType, 'Name>, value: seq<string * string>) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : M2ApplicationState<'EngineType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#timeouts-1">M2Application#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: M2ApplicationState<'EngineType, 'Name>, value: aws.M2Application.M2ApplicationTimeouts) : M2ApplicationState<'EngineType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : M2ApplicationState<'EngineType, 'Name>

        member _.Run(state: M2ApplicationState<Present, Present>) : aws.M2Application.M2Application =
            let config = aws.M2Application.M2ApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.M2Application.M2Application(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.m2Application: missing required arguments. Must call: engine_type, name.", 9999, IsError = true)>]
        member _.Run(_: M2ApplicationState<_, _>) : aws.M2Application.M2Application =
            Unchecked.defaultof<aws.M2Application.M2Application>

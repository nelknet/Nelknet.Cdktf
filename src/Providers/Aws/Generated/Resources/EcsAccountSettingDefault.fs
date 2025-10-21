namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsAccountSettingDefaultState<'Name, 'Value> = { assignments: ResizeArray<aws.EcsAccountSettingDefault.EcsAccountSettingDefaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_account_setting_default">aws_ecs_account_setting_default</a>.
    /// </summary>
    type EcsAccountSettingDefaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsAccountSettingDefaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsAccountSettingDefaultState<Missing, Missing>)

        member _.Zero(()) : EcsAccountSettingDefaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsAccountSettingDefaultState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_account_setting_default#name-1">EcsAccountSettingDefault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcsAccountSettingDefaultState<Missing, 'Value>, value: string) : EcsAccountSettingDefaultState<Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcsAccountSettingDefaultState<Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_account_setting_default#value-1">EcsAccountSettingDefault#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: EcsAccountSettingDefaultState<'Name, Missing>, value: string) : EcsAccountSettingDefaultState<'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : EcsAccountSettingDefaultState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_account_setting_default#id-1">EcsAccountSettingDefault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsAccountSettingDefaultState<'Name, 'Value>, value: string) : EcsAccountSettingDefaultState<'Name, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsAccountSettingDefaultState<'Name, 'Value>

        member _.Run(state: EcsAccountSettingDefaultState<Present, Present>) : aws.EcsAccountSettingDefault.EcsAccountSettingDefault =
            let config = aws.EcsAccountSettingDefault.EcsAccountSettingDefaultConfig()
            for setter in state.assignments do
                setter config
            aws.EcsAccountSettingDefault.EcsAccountSettingDefault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsAccountSettingDefault: missing required arguments. Must call: name, value.", 9999, IsError = true)>]
        member _.Run(_: EcsAccountSettingDefaultState<_, _>) : aws.EcsAccountSettingDefault.EcsAccountSettingDefault =
            Unchecked.defaultof<aws.EcsAccountSettingDefault.EcsAccountSettingDefault>

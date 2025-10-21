namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheUserState<'UserId> = { assignments: ResizeArray<aws.DataAwsElasticacheUser.DataAwsElasticacheUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user">aws_elasticache_user</a>.
    /// </summary>
    type DataAwsElasticacheUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheUserState<Missing>)

        member _.Zero(()) : DataAwsElasticacheUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#user_id-1">DataAwsElasticacheUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: DataAwsElasticacheUserState<Missing>, value: string) : DataAwsElasticacheUserState<Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheUserState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#access_string-1">DataAwsElasticacheUser#access_string</a>.
        /// </summary>
        [<CustomOperation "access_string">]
        member _.AccessString(state: DataAwsElasticacheUserState<'UserId>, value: string) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.AccessString <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// authentication_mode block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#authentication_mode-1">DataAwsElasticacheUser#authentication_mode</a> Accepts: aws.IResolvable | aws.DataAwsElasticacheUser.DataAwsElasticacheUserAuthenticationMode[]
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: DataAwsElasticacheUserState<'UserId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#engine-1">DataAwsElasticacheUser#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsElasticacheUserState<'UserId>, value: string) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#id-1">DataAwsElasticacheUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticacheUserState<'UserId>, value: string) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#no_password_required-1">DataAwsElasticacheUser#no_password_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "no_password_required">]
        member _.NoPasswordRequired(state: DataAwsElasticacheUserState<'UserId>, value: bool) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.NoPasswordRequired <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#no_password_required-1">DataAwsElasticacheUser#no_password_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "no_password_required">]
        member _.NoPasswordRequired(state: DataAwsElasticacheUserState<'UserId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.NoPasswordRequired <- value)
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#passwords-1">DataAwsElasticacheUser#passwords</a>.
        /// </summary>
        [<CustomOperation "passwords">]
        member _.Passwords(state: DataAwsElasticacheUserState<'UserId>, value: seq<string>) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.Passwords <- (value |> Seq.toArray))
            state : DataAwsElasticacheUserState<'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#user_name-1">DataAwsElasticacheUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataAwsElasticacheUserState<'UserId>, value: string) : DataAwsElasticacheUserState<'UserId> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : DataAwsElasticacheUserState<'UserId>

        member _.Run(state: DataAwsElasticacheUserState<Present>) : aws.DataAwsElasticacheUser.DataAwsElasticacheUser =
            let config = aws.DataAwsElasticacheUser.DataAwsElasticacheUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheUser.DataAwsElasticacheUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheUser: missing required arguments. Must call: user_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheUserState<_>) : aws.DataAwsElasticacheUser.DataAwsElasticacheUser =
            Unchecked.defaultof<aws.DataAwsElasticacheUser.DataAwsElasticacheUser>

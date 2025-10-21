namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> = { assignments: ResizeArray<aws.ElasticacheUser.ElasticacheUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user">aws_elasticache_user</a>.
    /// </summary>
    type ElasticacheUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ElasticacheUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#access_string-1">ElasticacheUser#access_string</a>.
        /// </summary>
        [<CustomOperation "access_string">]
        member _.AccessString(state: ElasticacheUserState<Missing, 'Engine, 'UserId, 'UserName>, value: string) : ElasticacheUserState<Present, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.AccessString <- value)
            ({ assignments = state.assignments } : ElasticacheUserState<Present, 'Engine, 'UserId, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#engine-1">ElasticacheUser#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: ElasticacheUserState<'AccessString, Missing, 'UserId, 'UserName>, value: string) : ElasticacheUserState<'AccessString, Present, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : ElasticacheUserState<'AccessString, Present, 'UserId, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#user_id-1">ElasticacheUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ElasticacheUserState<'AccessString, 'Engine, Missing, 'UserName>, value: string) : ElasticacheUserState<'AccessString, 'Engine, Present, 'UserName> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : ElasticacheUserState<'AccessString, 'Engine, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#user_name-1">ElasticacheUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, Missing>, value: string) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : ElasticacheUserState<'AccessString, 'Engine, 'UserId, Present>)

        /// <summary>
        /// authentication_mode block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#authentication_mode-1">ElasticacheUser#authentication_mode</a>
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: aws.ElasticacheUser.ElasticacheUserAuthenticationMode) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#id-1">ElasticacheUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: string) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#no_password_required-1">ElasticacheUser#no_password_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "no_password_required">]
        member _.NoPasswordRequired(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: bool) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.NoPasswordRequired <- value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#no_password_required-1">ElasticacheUser#no_password_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "no_password_required">]
        member _.NoPasswordRequired(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.NoPasswordRequired <- value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#passwords-1">ElasticacheUser#passwords</a>.
        /// </summary>
        [<CustomOperation "passwords">]
        member _.Passwords(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: seq<string>) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.Passwords <- (value |> Seq.toArray))
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#tags-1">ElasticacheUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: seq<string * string>) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#tags_all-1">ElasticacheUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: seq<string * string>) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#timeouts-1">ElasticacheUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>, value: aws.ElasticacheUser.ElasticacheUserTimeouts) : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheUserState<'AccessString, 'Engine, 'UserId, 'UserName>

        member _.Run(state: ElasticacheUserState<Present, Present, Present, Present>) : aws.ElasticacheUser.ElasticacheUser =
            let config = aws.ElasticacheUser.ElasticacheUserConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheUser.ElasticacheUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheUser: missing required arguments. Must call: access_string, engine, user_id, user_name.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheUserState<_, _, _, _>) : aws.ElasticacheUser.ElasticacheUser =
            Unchecked.defaultof<aws.ElasticacheUser.ElasticacheUser>

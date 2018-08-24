// Generated by sprotodump. DO NOT EDIT!
// source: ../../Lua/Proto/proto_100_199_scene.lua ../../Lua/Proto/proto_1_99_account.lua

using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType { 
	public class account_create_role {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private Int64 _career; // tag 0
			public Int64 career {
				get { return _career; }
				set { base.has_field.set_field (0, true); _career = value; }
			}
			public bool HasCareer {
				get { return base.has_field.has_field (0); }
			}

			private string _name; // tag 1
			public string name {
				get { return _name; }
				set { base.has_field.set_field (1, true); _name = value; }
			}
			public bool HasName {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.career = base.deserialize.read_integer ();
						break;
					case 1:
						this.name = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.career, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.name, 1);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private Int64 _result; // tag 0
			public Int64 result {
				get { return _result; }
				set { base.has_field.set_field (0, true); _result = value; }
			}
			public bool HasResult {
				get { return base.has_field.has_field (0); }
			}

			private Int64 _role_id; // tag 1
			public Int64 role_id {
				get { return _role_id; }
				set { base.has_field.set_field (1, true); _role_id = value; }
			}
			public bool HasRole_id {
				get { return base.has_field.has_field (1); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.result = base.deserialize.read_integer ();
						break;
					case 1:
						this.role_id = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.result, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_integer (this.role_id, 1);
				}

				return base.serialize.close ();
			}
		}


	}


	public class account_delete_role {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private Int64 _role_id; // tag 0
			public Int64 role_id {
				get { return _role_id; }
				set { base.has_field.set_field (0, true); _role_id = value; }
			}
			public bool HasRole_id {
				get { return base.has_field.has_field (0); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.role_id = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.role_id, 0);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private Int64 _result; // tag 0
			public Int64 result {
				get { return _result; }
				set { base.has_field.set_field (0, true); _result = value; }
			}
			public bool HasResult {
				get { return base.has_field.has_field (0); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.result = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.result, 0);
				}

				return base.serialize.close ();
			}
		}


	}


	public class account_get_role_list {
	
		public class response : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private List<role_figure> _role_list; // tag 0
			public List<role_figure> role_list {
				get { return _role_list; }
				set { base.has_field.set_field (0, true); _role_list = value; }
			}
			public bool HasRole_list {
				get { return base.has_field.has_field (0); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.role_list = base.deserialize.read_obj_list<role_figure> ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_obj (this.role_list, 0);
				}

				return base.serialize.close ();
			}
		}


	}


	public class account_get_server_time {
	
		public class response : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private Int64 _server_time; // tag 0
			public Int64 server_time {
				get { return _server_time; }
				set { base.has_field.set_field (0, true); _server_time = value; }
			}
			public bool HasServer_time {
				get { return base.has_field.has_field (0); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.server_time = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.server_time, 0);
				}

				return base.serialize.close ();
			}
		}


	}


	public class account_select_role_enter_game {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private Int64 _role_id; // tag 0
			public Int64 role_id {
				get { return _role_id; }
				set { base.has_field.set_field (0, true); _role_id = value; }
			}
			public bool HasRole_id {
				get { return base.has_field.has_field (0); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.role_id = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.role_id, 0);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private Int64 _result; // tag 0
			public Int64 result {
				get { return _result; }
				set { base.has_field.set_field (0, true); _result = value; }
			}
			public bool HasResult {
				get { return base.has_field.has_field (0); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.result = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.result, 0);
				}

				return base.serialize.close ();
			}
		}


	}


	public class role_figure : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		private Int64 _role_id; // tag 0
		public Int64 role_id {
			get { return _role_id; }
			set { base.has_field.set_field (0, true); _role_id = value; }
		}
		public bool HasRole_id {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _career; // tag 1
		public Int64 career {
			get { return _career; }
			set { base.has_field.set_field (1, true); _career = value; }
		}
		public bool HasCareer {
			get { return base.has_field.has_field (1); }
		}

		private string _name; // tag 2
		public string name {
			get { return _name; }
			set { base.has_field.set_field (2, true); _name = value; }
		}
		public bool HasName {
			get { return base.has_field.has_field (2); }
		}

		public role_figure () : base(max_field_count) {}

		public role_figure (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.role_id = base.deserialize.read_integer ();
					break;
				case 1:
					this.career = base.deserialize.read_integer ();
					break;
				case 2:
					this.name = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.role_id, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.career, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_string (this.name, 2);
			}

			return base.serialize.close ();
		}
	}


	public class scene_get_cur_scene_info {
	
		public class response : SprotoTypeBase {
			private static int max_field_count = 3;
			
			
			private List<scene_role_info> _role_list; // tag 0
			public List<scene_role_info> role_list {
				get { return _role_list; }
				set { base.has_field.set_field (0, true); _role_list = value; }
			}
			public bool HasRole_list {
				get { return base.has_field.has_field (0); }
			}

			private List<scene_monster_info> _monster_list; // tag 1
			public List<scene_monster_info> monster_list {
				get { return _monster_list; }
				set { base.has_field.set_field (1, true); _monster_list = value; }
			}
			public bool HasMonster_list {
				get { return base.has_field.has_field (1); }
			}

			private List<scene_npc_info> _npc_list; // tag 2
			public List<scene_npc_info> npc_list {
				get { return _npc_list; }
				set { base.has_field.set_field (2, true); _npc_list = value; }
			}
			public bool HasNpc_list {
				get { return base.has_field.has_field (2); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.role_list = base.deserialize.read_obj_list<scene_role_info> ();
						break;
					case 1:
						this.monster_list = base.deserialize.read_obj_list<scene_monster_info> ();
						break;
					case 2:
						this.npc_list = base.deserialize.read_obj_list<scene_npc_info> ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_obj (this.role_list, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_obj (this.monster_list, 1);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_obj (this.npc_list, 2);
				}

				return base.serialize.close ();
			}
		}


	}


	public class scene_get_main_role_info {
	
		public class response : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private scene_main_role_info _role_info; // tag 0
			public scene_main_role_info role_info {
				get { return _role_info; }
				set { base.has_field.set_field (0, true); _role_info = value; }
			}
			public bool HasRole_info {
				get { return base.has_field.has_field (0); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.role_info = base.deserialize.read_obj<scene_main_role_info> ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_obj (this.role_info, 0);
				}

				return base.serialize.close ();
			}
		}


	}


	public class scene_main_role_info : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		private Int64 _role_id; // tag 0
		public Int64 role_id {
			get { return _role_id; }
			set { base.has_field.set_field (0, true); _role_id = value; }
		}
		public bool HasRole_id {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _career; // tag 1
		public Int64 career {
			get { return _career; }
			set { base.has_field.set_field (1, true); _career = value; }
		}
		public bool HasCareer {
			get { return base.has_field.has_field (1); }
		}

		private string _name; // tag 2
		public string name {
			get { return _name; }
			set { base.has_field.set_field (2, true); _name = value; }
		}
		public bool HasName {
			get { return base.has_field.has_field (2); }
		}

		public scene_main_role_info () : base(max_field_count) {}

		public scene_main_role_info (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.role_id = base.deserialize.read_integer ();
					break;
				case 1:
					this.career = base.deserialize.read_integer ();
					break;
				case 2:
					this.name = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.role_id, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.career, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_string (this.name, 2);
			}

			return base.serialize.close ();
		}
	}


	public class scene_monster_info : SprotoTypeBase {
		private static int max_field_count = 4;
		
		
		private Int64 _monster_id; // tag 0
		public Int64 monster_id {
			get { return _monster_id; }
			set { base.has_field.set_field (0, true); _monster_id = value; }
		}
		public bool HasMonster_id {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _monster_type_id; // tag 1
		public Int64 monster_type_id {
			get { return _monster_type_id; }
			set { base.has_field.set_field (1, true); _monster_type_id = value; }
		}
		public bool HasMonster_type_id {
			get { return base.has_field.has_field (1); }
		}

		private Int64 _hp; // tag 2
		public Int64 hp {
			get { return _hp; }
			set { base.has_field.set_field (2, true); _hp = value; }
		}
		public bool HasHp {
			get { return base.has_field.has_field (2); }
		}

		private Int64 _maxhp; // tag 3
		public Int64 maxhp {
			get { return _maxhp; }
			set { base.has_field.set_field (3, true); _maxhp = value; }
		}
		public bool HasMaxhp {
			get { return base.has_field.has_field (3); }
		}

		public scene_monster_info () : base(max_field_count) {}

		public scene_monster_info (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.monster_id = base.deserialize.read_integer ();
					break;
				case 1:
					this.monster_type_id = base.deserialize.read_integer ();
					break;
				case 2:
					this.hp = base.deserialize.read_integer ();
					break;
				case 3:
					this.maxhp = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.monster_id, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.monster_type_id, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_integer (this.hp, 2);
			}

			if (base.has_field.has_field (3)) {
				base.serialize.write_integer (this.maxhp, 3);
			}

			return base.serialize.close ();
		}
	}


	public class scene_npc_info : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private Int64 _npc_id; // tag 0
		public Int64 npc_id {
			get { return _npc_id; }
			set { base.has_field.set_field (0, true); _npc_id = value; }
		}
		public bool HasNpc_id {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _npc_type_id; // tag 1
		public Int64 npc_type_id {
			get { return _npc_type_id; }
			set { base.has_field.set_field (1, true); _npc_type_id = value; }
		}
		public bool HasNpc_type_id {
			get { return base.has_field.has_field (1); }
		}

		public scene_npc_info () : base(max_field_count) {}

		public scene_npc_info (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.npc_id = base.deserialize.read_integer ();
					break;
				case 1:
					this.npc_type_id = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.npc_id, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.npc_type_id, 1);
			}

			return base.serialize.close ();
		}
	}


	public class scene_role_info : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		private Int64 _role_id; // tag 0
		public Int64 role_id {
			get { return _role_id; }
			set { base.has_field.set_field (0, true); _role_id = value; }
		}
		public bool HasRole_id {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _career; // tag 1
		public Int64 career {
			get { return _career; }
			set { base.has_field.set_field (1, true); _career = value; }
		}
		public bool HasCareer {
			get { return base.has_field.has_field (1); }
		}

		private string _name; // tag 2
		public string name {
			get { return _name; }
			set { base.has_field.set_field (2, true); _name = value; }
		}
		public bool HasName {
			get { return base.has_field.has_field (2); }
		}

		public scene_role_info () : base(max_field_count) {}

		public scene_role_info (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.role_id = base.deserialize.read_integer ();
					break;
				case 1:
					this.career = base.deserialize.read_integer ();
					break;
				case 2:
					this.name = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.role_id, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.career, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_string (this.name, 2);
			}

			return base.serialize.close ();
		}
	}


	public class scene_walk {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 7;
			
			
			private Int64 _pos_x; // tag 0
			public Int64 pos_x {
				get { return _pos_x; }
				set { base.has_field.set_field (0, true); _pos_x = value; }
			}
			public bool HasPos_x {
				get { return base.has_field.has_field (0); }
			}

			private Int64 _pos_y; // tag 1
			public Int64 pos_y {
				get { return _pos_y; }
				set { base.has_field.set_field (1, true); _pos_y = value; }
			}
			public bool HasPos_y {
				get { return base.has_field.has_field (1); }
			}

			private Int64 _pos_z; // tag 2
			public Int64 pos_z {
				get { return _pos_z; }
				set { base.has_field.set_field (2, true); _pos_z = value; }
			}
			public bool HasPos_z {
				get { return base.has_field.has_field (2); }
			}

			private Int64 _dir_x; // tag 3
			public Int64 dir_x {
				get { return _dir_x; }
				set { base.has_field.set_field (3, true); _dir_x = value; }
			}
			public bool HasDir_x {
				get { return base.has_field.has_field (3); }
			}

			private Int64 _dir_y; // tag 4
			public Int64 dir_y {
				get { return _dir_y; }
				set { base.has_field.set_field (4, true); _dir_y = value; }
			}
			public bool HasDir_y {
				get { return base.has_field.has_field (4); }
			}

			private Int64 _dir_z; // tag 5
			public Int64 dir_z {
				get { return _dir_z; }
				set { base.has_field.set_field (5, true); _dir_z = value; }
			}
			public bool HasDir_z {
				get { return base.has_field.has_field (5); }
			}

			private Int64 _time; // tag 6
			public Int64 time {
				get { return _time; }
				set { base.has_field.set_field (6, true); _time = value; }
			}
			public bool HasTime {
				get { return base.has_field.has_field (6); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.pos_x = base.deserialize.read_integer ();
						break;
					case 1:
						this.pos_y = base.deserialize.read_integer ();
						break;
					case 2:
						this.pos_z = base.deserialize.read_integer ();
						break;
					case 3:
						this.dir_x = base.deserialize.read_integer ();
						break;
					case 4:
						this.dir_y = base.deserialize.read_integer ();
						break;
					case 5:
						this.dir_z = base.deserialize.read_integer ();
						break;
					case 6:
						this.time = base.deserialize.read_integer ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.pos_x, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_integer (this.pos_y, 1);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_integer (this.pos_z, 2);
				}

				if (base.has_field.has_field (3)) {
					base.serialize.write_integer (this.dir_x, 3);
				}

				if (base.has_field.has_field (4)) {
					base.serialize.write_integer (this.dir_y, 4);
				}

				if (base.has_field.has_field (5)) {
					base.serialize.write_integer (this.dir_z, 5);
				}

				if (base.has_field.has_field (6)) {
					base.serialize.write_integer (this.time, 6);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 0;
			
			
			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				return base.serialize.close ();
			}
		}


	}


}


public class Protocol : ProtocolBase {
	public static  Protocol Instance = new Protocol();
	private Protocol() {
		Protocol.SetProtocol<account_create_role> (account_create_role.Tag);
		Protocol.SetRequest<SprotoType.account_create_role.request> (account_create_role.Tag);
		Protocol.SetResponse<SprotoType.account_create_role.response> (account_create_role.Tag);

		Protocol.SetProtocol<account_delete_role> (account_delete_role.Tag);
		Protocol.SetRequest<SprotoType.account_delete_role.request> (account_delete_role.Tag);
		Protocol.SetResponse<SprotoType.account_delete_role.response> (account_delete_role.Tag);

		Protocol.SetProtocol<account_get_role_list> (account_get_role_list.Tag);
		Protocol.SetResponse<SprotoType.account_get_role_list.response> (account_get_role_list.Tag);

		Protocol.SetProtocol<account_get_server_time> (account_get_server_time.Tag);
		Protocol.SetResponse<SprotoType.account_get_server_time.response> (account_get_server_time.Tag);

		Protocol.SetProtocol<account_select_role_enter_game> (account_select_role_enter_game.Tag);
		Protocol.SetRequest<SprotoType.account_select_role_enter_game.request> (account_select_role_enter_game.Tag);
		Protocol.SetResponse<SprotoType.account_select_role_enter_game.response> (account_select_role_enter_game.Tag);

		Protocol.SetProtocol<scene_get_cur_scene_info> (scene_get_cur_scene_info.Tag);
		Protocol.SetResponse<SprotoType.scene_get_cur_scene_info.response> (scene_get_cur_scene_info.Tag);

		Protocol.SetProtocol<scene_get_main_role_info> (scene_get_main_role_info.Tag);
		Protocol.SetResponse<SprotoType.scene_get_main_role_info.response> (scene_get_main_role_info.Tag);

		Protocol.SetProtocol<scene_walk> (scene_walk.Tag);
		Protocol.SetRequest<SprotoType.scene_walk.request> (scene_walk.Tag);
		Protocol.SetResponse<SprotoType.scene_walk.response> (scene_walk.Tag);

	}

	public class account_create_role {
		public const int Tag = 3;
	}

	public class account_delete_role {
		public const int Tag = 4;
	}

	public class account_get_role_list {
		public const int Tag = 2;
	}

	public class account_get_server_time {
		public const int Tag = 1;
	}

	public class account_select_role_enter_game {
		public const int Tag = 5;
	}

	public class scene_get_cur_scene_info {
		public const int Tag = 101;
	}

	public class scene_get_main_role_info {
		public const int Tag = 100;
	}

	public class scene_walk {
		public const int Tag = 102;
	}

}
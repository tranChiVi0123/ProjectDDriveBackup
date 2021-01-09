<template>
  <div class="user">
    <p>{{user.email}}</p>
    <button v-on:click="HandleDelete">Delete</button>
  </div>
</template>

<script>
export default {
  name: "user",
  data() {
    return {};
  },
  props: {
    user: {
      type: Object,
      default: null
    }
  },
  methods: {
    HandleDelete() {
      console.log("User.Vue Called");
      console.log(this.user.email);
      this.$emit("HandleDelete", this.user.email);
    }
  }
};
</script>

<style>
.user {
  padding: 30px;
  margin-bottom: 30px;
  border: 2px slide yellow;
  width: calc(33.3333% -20px);
}
</style>
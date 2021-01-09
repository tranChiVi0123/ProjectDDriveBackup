<template>
  <h1>
    {{title}}
    <button v-on:click="handleChangeTitleEvent">Thay đổi từ Header</button>
  </h1>
</template>

<script>
export default {
  name: "component-header",
  data() {
    return {};
  },
  props: {
    title: String
  },
  methods: {
    handleChangeTitleEvent() {
      console.log("Before emit");
      this.$emit("handleHeaderEvent");
      console.log("After emint");
    }
  }
};
</script>

<style>
</style>